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
    public partial class RegisterForm : Form
    {
        Point lastPoint;

        public RegisterForm()
        {
            InitializeComponent();
            userNameField.Text = "Введите имя";
            userSurnameField.Text = "Введите фамилию";
        }

        private void close_label_Click(object sender, EventArgs e)
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

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
                userNameField.Text = "";
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Введите фамилию")
                userSurnameField.Text = "";
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
                userNameField.Text = "Введите имя";
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
                userSurnameField.Text = "Введите фамилию";
        }

        //Регистрация
        private void register_button_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введите имя")
                return;

            if (userSurnameField.Text == "Введите фамилию")
                return;

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_box.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password_box.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            db.OpenConnection();  //Открытие базы данных

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт создан");
            else
                MessageBox.Show("Аккаунт не создан");

            db.CloseConnection(); //Закрытие базы данных
        }

        public bool isUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());
            
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login_box.Text;

            adapter.SelectCommand = command; //Указываем какую команду будем выполнять
            adapter.Fill(table);             //Заполняем таблицу данными

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин есть, введите другой");
                return true;
            }
            else
                return false;
        }

        private void goReg_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
