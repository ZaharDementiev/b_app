using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Pages;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        Point lastPoint;
        public MainForm()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            AddItem addItem = new AddItem();
            addItem.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
            EquipmentInfo equipmentInfo = new EquipmentInfo();
            equipmentInfo.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            MovementHistoryForm movementHistory = new MovementHistoryForm();
            movementHistory.Show();
        }
    }
}
