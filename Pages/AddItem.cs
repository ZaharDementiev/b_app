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
    public partial class AddItem : Form
    {
        Equipment equipment;
        Point lastPoint;

        public AddItem()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (suppliersName.Text != "" &&
                producerName.Text != "" &&
                equipmentType.Text != "" &&
                location.Text != "" &&
                tradingEquipment.Text != "")
                equipment = new Equipment(suppliersName.Text, producerName.Text, equipmentType.Text, location.Text, tradingEquipment.Text);
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
    }
}
