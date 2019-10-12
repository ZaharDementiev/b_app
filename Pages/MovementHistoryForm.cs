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
using WindowsFormsApp1.Directory;

namespace WindowsFormsApp1.Pages
{
    public partial class MovementHistoryForm : Form
    {
        List<string[]> list = new List<string[]>();

        public MovementHistoryForm()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            dataGrid.Rows.Clear();
            WriteEquipmentLists();

            foreach (string[] s in list)
                dataGrid.Rows.Add(s);

            list.Clear();
        }

        private void WriteEquipmentLists()
        {
            string connStr = "server = localhost; port = 3306; username = root; password = root; database = testapp";
            MySqlConnection mySqlConnection = new MySqlConnection(connStr);

            mySqlConnection.Open();

            string sql = "SELECT id, old_location, actual_location, eq_name FROM location_changes";

            MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new string[6]);

                list[list.Count - 1][0] = reader[0].ToString();
                list[list.Count - 1][1] = reader[1].ToString();
                list[list.Count - 1][2] = reader[2].ToString();
                list[list.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();

            mySqlConnection.Close();
        }

        private void goReg_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
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
    }
}
