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

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        Point lastPoint;

        public LoginForm()
        {
            InitializeComponent();
            password_box.AutoSize = false;
            password_box.Size = new Size(password_box.Size.Width, login_box.Size.Height);
        }

        //Кнопка входа
        private void enter_button_Click(object sender, EventArgs e)
        {
            string loginUser = login_box.Text;
            string passUser = password_box.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.GetConnection());

            //Присваиваем заглушкам логин и пароль соответсвенно
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command; //Указываем какую команду будем выполнять
            adapter.Fill(table);             //Заполняем таблицу данными

            if (table.Rows.Count > 0)
            {
                Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
                MessageBox.Show("Пользователь не найден");
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
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
