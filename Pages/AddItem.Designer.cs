namespace WindowsFormsApp1.Pages
{
    partial class AddItem
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
            this.close_label = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goReg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.tradingEquipment = new System.Windows.Forms.TextBox();
            this.location = new System.Windows.Forms.TextBox();
            this.equipmentType = new System.Windows.Forms.TextBox();
            this.producerName = new System.Windows.Forms.TextBox();
            this.suppliersName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // close_label
            // 
            this.close_label.AutoSize = true;
            this.close_label.BackColor = System.Drawing.SystemColors.Highlight;
            this.close_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_label.Location = new System.Drawing.Point(767, 0);
            this.close_label.Name = "close_label";
            this.close_label.Size = new System.Drawing.Size(33, 31);
            this.close_label.TabIndex = 1;
            this.close_label.Text = "X";
            this.close_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_label.Click += new System.EventHandler(this.CloseLabelClick);
            this.close_label.MouseEnter += new System.EventHandler(this.Close_Label_MouseEnter);
            this.close_label.MouseLeave += new System.EventHandler(this.Close_Label_MouseLeave);
            // 
            // mainLabel
            // 
            this.mainLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.mainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainLabel.Location = new System.Drawing.Point(0, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(800, 122);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Добавить оборудование";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.mainLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.goReg);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.tradingEquipment);
            this.panel1.Controls.Add(this.location);
            this.panel1.Controls.Add(this.equipmentType);
            this.panel1.Controls.Add(this.producerName);
            this.panel1.Controls.Add(this.suppliersName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // goReg
            // 
            this.goReg.AutoSize = true;
            this.goReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goReg.Location = new System.Drawing.Point(334, 425);
            this.goReg.Name = "goReg";
            this.goReg.Size = new System.Drawing.Size(50, 16);
            this.goReg.TabIndex = 17;
            this.goReg.Text = "Назад";
            this.goReg.Click += new System.EventHandler(this.goReg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Торговое оборудование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(455, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Расположение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Тип оборудования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(455, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Производитель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Поставщик";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(458, 327);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(259, 67);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Добавить оборудование";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tradingEquipment
            // 
            this.tradingEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tradingEquipment.Location = new System.Drawing.Point(25, 327);
            this.tradingEquipment.Multiline = true;
            this.tradingEquipment.Name = "tradingEquipment";
            this.tradingEquipment.Size = new System.Drawing.Size(259, 31);
            this.tradingEquipment.TabIndex = 10;
            // 
            // location
            // 
            this.location.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.location.Location = new System.Drawing.Point(458, 255);
            this.location.Multiline = true;
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(259, 31);
            this.location.TabIndex = 9;
            // 
            // equipmentType
            // 
            this.equipmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equipmentType.Location = new System.Drawing.Point(25, 255);
            this.equipmentType.Multiline = true;
            this.equipmentType.Name = "equipmentType";
            this.equipmentType.Size = new System.Drawing.Size(259, 31);
            this.equipmentType.TabIndex = 8;
            // 
            // producerName
            // 
            this.producerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.producerName.Location = new System.Drawing.Point(458, 185);
            this.producerName.Multiline = true;
            this.producerName.Name = "producerName";
            this.producerName.Size = new System.Drawing.Size(259, 31);
            this.producerName.TabIndex = 7;
            // 
            // suppliersName
            // 
            this.suppliersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.suppliersName.Location = new System.Drawing.Point(25, 185);
            this.suppliersName.Multiline = true;
            this.suppliersName.Name = "suppliersName";
            this.suppliersName.Size = new System.Drawing.Size(259, 31);
            this.suppliersName.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.close_label);
            this.panel2.Controls.Add(this.mainLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 122);
            this.panel2.TabIndex = 0;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label close_label;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox suppliersName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox tradingEquipment;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.TextBox equipmentType;
        private System.Windows.Forms.TextBox producerName;
        private System.Windows.Forms.Label goReg;
    }
}