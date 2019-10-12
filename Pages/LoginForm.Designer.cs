namespace WindowsFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.enter_button = new System.Windows.Forms.Button();
            this.password_label = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.login_box = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_label = new System.Windows.Forms.Label();
            this.login_label_main = new System.Windows.Forms.Label();
            this.goReg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.goReg);
            this.panel1.Controls.Add(this.enter_button);
            this.panel1.Controls.Add(this.password_label);
            this.panel1.Controls.Add(this.password_box);
            this.panel1.Controls.Add(this.login_label);
            this.panel1.Controls.Add(this.login_box);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 434);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.LightGreen;
            this.enter_button.FlatAppearance.BorderSize = 0;
            this.enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter_button.Location = new System.Drawing.Point(104, 332);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(228, 53);
            this.enter_button.TabIndex = 4;
            this.enter_button.Text = "Войти";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // password_label
            // 
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.Location = new System.Drawing.Point(12, 246);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(86, 31);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Пароль";
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_box.Location = new System.Drawing.Point(104, 246);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(228, 31);
            this.password_box.TabIndex = 3;
            this.password_box.UseSystemPasswordChar = true;
            // 
            // login_label
            // 
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(12, 188);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(65, 31);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Логин";
            // 
            // login_box
            // 
            this.login_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_box.Location = new System.Drawing.Point(104, 188);
            this.login_box.Multiline = true;
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(228, 31);
            this.login_box.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.close_label);
            this.panel2.Controls.Add(this.login_label_main);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 122);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // close_label
            // 
            this.close_label.AutoSize = true;
            this.close_label.BackColor = System.Drawing.SystemColors.Highlight;
            this.close_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_label.Location = new System.Drawing.Point(373, 0);
            this.close_label.Name = "close_label";
            this.close_label.Size = new System.Drawing.Size(33, 31);
            this.close_label.TabIndex = 1;
            this.close_label.Text = "X";
            this.close_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_label.Click += new System.EventHandler(this.CloseLabelClick);
            this.close_label.MouseEnter += new System.EventHandler(this.Close_Label_MouseEnter);
            this.close_label.MouseLeave += new System.EventHandler(this.Close_Label_MouseLeave);
            // 
            // login_label_main
            // 
            this.login_label_main.BackColor = System.Drawing.SystemColors.Highlight;
            this.login_label_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login_label_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label_main.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_label_main.Location = new System.Drawing.Point(0, 0);
            this.login_label_main.Name = "login_label_main";
            this.login_label_main.Size = new System.Drawing.Size(406, 122);
            this.login_label_main.TabIndex = 0;
            this.login_label_main.Text = "Авторизация";
            this.login_label_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_label_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.login_label_main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // goReg
            // 
            this.goReg.AutoSize = true;
            this.goReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goReg.Location = new System.Drawing.Point(141, 399);
            this.goReg.Name = "goReg";
            this.goReg.Size = new System.Drawing.Size(133, 16);
            this.goReg.TabIndex = 5;
            this.goReg.Text = "Еще нет аккаунта?";
            this.goReg.Click += new System.EventHandler(this.goReg_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 434);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Label close_label;
        private System.Windows.Forms.Label login_label_main;
        private System.Windows.Forms.Label goReg;
    }
}