using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pages
{
    public partial class EquipmentInfo : Form
    {
        Point lastPoint;
        List<string[]> list = new List<string[]>();
        List<string> location = new List<string>();
        List<string> eqType = new List<string>();

        public EquipmentInfo()
        {
            InitializeComponent();
            dataTable.Visible = false;

            checkedList.Visible = false;
            button1.Visible = false;
            newLoc.Visible = false;
            dataTable.Visible = false;
        }

        private void CloseLabelClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Close_Label_MouseLeave(object sender, EventArgs e)
        {
            close_label.ForeColor = Color.Black;
        }

        private void Close_Label_MouseEnter(object sender, EventArgs e)
        {
            close_label.ForeColor = Color.Red;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void goReg_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void WriteEquipmentLists()
        {
            string connStr = "server = localhost; port = 3306; username = root; password = root; database = testapp";
            MySqlConnection mySqlConnection = new MySqlConnection(connStr);

            mySqlConnection.Open();

            string sql = "SELECT id, suppliers, producer, equipment_type, location, trading_equipment FROM equipment";

            MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new string[6]);

                list[list.Count - 1][0] = reader[0].ToString();
                list[list.Count - 1][1] = reader[1].ToString();
                list[list.Count - 1][2] = reader[2].ToString();
                list[list.Count - 1][3] = reader[3].ToString();
                eqType.Add(reader[3].ToString());
                list[list.Count - 1][4] = reader[4].ToString();
                location.Add(reader[4].ToString());
                list[list.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();

            mySqlConnection.Close();
        }  

        private void showButton_Click(object sender, EventArgs e)
        {
            dataTable.Visible = true;
            checkedList.Visible = false;
            button1.Visible = false;
            newLoc.Visible = false;

            dataTable.Rows.Clear();
            WriteEquipmentLists();

            foreach (string[] s in list)
                dataTable.Rows.Add(s);

            list.Clear();
            location.Clear();
            eqType.Clear();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            dataTable.Visible = false;
            checkedList.Visible = true;
            button1.Visible = true;
            newLoc.Visible = true;

            checkedList.Items.Clear();
            WriteEquipmentLists();

            foreach (string s in location)
                checkedList.Items.Add(s);

            list.Clear();
            location.Clear();
            eqType.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteEquipmentLists();
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `location_changes` (`old_location`, `actual_location`, `eq_name`) " +
                "VALUES (@oL, @aL, @eN);", db.GetConnection());

            command.Parameters.Add("@oL", MySqlDbType.VarChar).Value = location[checkedList.SelectedIndex];
            command.Parameters.Add("@aL", MySqlDbType.VarChar).Value = newLoc.Text;
            command.Parameters.Add("@eN", MySqlDbType.VarChar).Value = eqType[checkedList.SelectedIndex];

            db.OpenConnection();  //Открытие базы данных

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Товар перемещен");
            else
                MessageBox.Show("Товар не перемещен");

            db.CloseConnection(); //Закрытие базы данных            
            
            list.Clear();
            location.Clear();
            eqType.Clear();
        }

        private void checkedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedList.Items.Count; ++ix)
                if (ix != e.Index) checkedList.SetItemChecked(ix, false);
        }
    }
}
