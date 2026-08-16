namespace InventoryManagementSystem.Forms
{
    partial class AddDeviceForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Brand = new System.Windows.Forms.ComboBox();
            this.cmb_MaterialType = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Employee = new System.Windows.Forms.ComboBox();
            this.cmb_Facility = new System.Windows.Forms.ComboBox();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SerialNumber = new System.Windows.Forms.TextBox();
            this.txt_DeviceModel = new System.Windows.Forms.TextBox();
            this.txt_Cpu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Ram = new System.Windows.Forms.TextBox();
            this.txt_DiskSize = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_EstimatedLife = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp_ActivationDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_AssignmentDate = new System.Windows.Forms.DateTimePicker();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(187, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Malzeme Tipi";
            // 
            // cmb_Brand
            // 
            this.cmb_Brand.FormattingEnabled = true;
            this.cmb_Brand.Location = new System.Drawing.Point(29, 138);
            this.cmb_Brand.Name = "cmb_Brand";
            this.cmb_Brand.Size = new System.Drawing.Size(121, 28);
            this.cmb_Brand.TabIndex = 4;
            // 
            // cmb_MaterialType
            // 
            this.cmb_MaterialType.FormattingEnabled = true;
            this.cmb_MaterialType.Location = new System.Drawing.Point(186, 138);
            this.cmb_MaterialType.Name = "cmb_MaterialType";
            this.cmb_MaterialType.Size = new System.Drawing.Size(121, 28);
            this.cmb_MaterialType.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(566, 377);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(97, 34);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Kaydet";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(669, 377);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(97, 34);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "İptal";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Personel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(300, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tesis";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(369, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum";
            // 
            // cmb_Employee
            // 
            this.cmb_Employee.FormattingEnabled = true;
            this.cmb_Employee.Location = new System.Drawing.Point(29, 383);
            this.cmb_Employee.Name = "cmb_Employee";
            this.cmb_Employee.Size = new System.Drawing.Size(261, 28);
            this.cmb_Employee.TabIndex = 11;
            // 
            // cmb_Facility
            // 
            this.cmb_Facility.FormattingEnabled = true;
            this.cmb_Facility.Location = new System.Drawing.Point(296, 383);
            this.cmb_Facility.Name = "cmb_Facility";
            this.cmb_Facility.Size = new System.Drawing.Size(238, 28);
            this.cmb_Facility.TabIndex = 12;
            // 
            // cmb_Status
            // 
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(373, 40);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(121, 28);
            this.cmb_Status.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Seri Numarası";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Model";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(187, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "CPU";
            // 
            // txt_SerialNumber
            // 
            this.txt_SerialNumber.Location = new System.Drawing.Point(29, 40);
            this.txt_SerialNumber.Name = "txt_SerialNumber";
            this.txt_SerialNumber.Size = new System.Drawing.Size(121, 26);
            this.txt_SerialNumber.TabIndex = 17;
            // 
            // txt_DeviceModel
            // 
            this.txt_DeviceModel.Location = new System.Drawing.Point(29, 218);
            this.txt_DeviceModel.Name = "txt_DeviceModel";
            this.txt_DeviceModel.Size = new System.Drawing.Size(100, 26);
            this.txt_DeviceModel.TabIndex = 18;
            // 
            // txt_Cpu
            // 
            this.txt_Cpu.Location = new System.Drawing.Point(186, 220);
            this.txt_Cpu.Name = "txt_Cpu";
            this.txt_Cpu.Size = new System.Drawing.Size(100, 26);
            this.txt_Cpu.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "RAM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(187, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Disk";
            // 
            // txt_Ram
            // 
            this.txt_Ram.Location = new System.Drawing.Point(30, 301);
            this.txt_Ram.Name = "txt_Ram";
            this.txt_Ram.Size = new System.Drawing.Size(100, 26);
            this.txt_Ram.TabIndex = 22;
            // 
            // txt_DiskSize
            // 
            this.txt_DiskSize.Location = new System.Drawing.Point(191, 301);
            this.txt_DiskSize.Name = "txt_DiskSize";
            this.txt_DiskSize.Size = new System.Drawing.Size(100, 26);
            this.txt_DiskSize.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(562, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tahmini Ömür";
            // 
            // txt_EstimatedLife
            // 
            this.txt_EstimatedLife.Location = new System.Drawing.Point(566, 42);
            this.txt_EstimatedLife.Name = "txt_EstimatedLife";
            this.txt_EstimatedLife.Size = new System.Drawing.Size(100, 26);
            this.txt_EstimatedLife.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(369, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Aktivasyon Tarihi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(610, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Zimmet Tarihi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(522, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Açıklama";
            // 
            // dtp_ActivationDate
            // 
            this.dtp_ActivationDate.Location = new System.Drawing.Point(334, 138);
            this.dtp_ActivationDate.Name = "dtp_ActivationDate";
            this.dtp_ActivationDate.Size = new System.Drawing.Size(200, 26);
            this.dtp_ActivationDate.TabIndex = 29;
            this.dtp_ActivationDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtp_AssignmentDate
            // 
            this.dtp_AssignmentDate.Location = new System.Drawing.Point(566, 136);
            this.dtp_AssignmentDate.Name = "dtp_AssignmentDate";
            this.dtp_AssignmentDate.Size = new System.Drawing.Size(200, 26);
            this.dtp_AssignmentDate.TabIndex = 30;
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(373, 220);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Notes.Size = new System.Drawing.Size(393, 107);
            this.txt_Notes.TabIndex = 31;
            // 
            // AddDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.dtp_AssignmentDate);
            this.Controls.Add(this.dtp_ActivationDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_EstimatedLife);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_DiskSize);
            this.Controls.Add(this.txt_Ram);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Cpu);
            this.Controls.Add(this.txt_DeviceModel);
            this.Controls.Add(this.txt_SerialNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.cmb_Facility);
            this.Controls.Add(this.cmb_Employee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_MaterialType);
            this.Controls.Add(this.cmb_Brand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDeviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Cihaz Ekle";
            this.Load += new System.EventHandler(this.AddDeviceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Brand;
        private System.Windows.Forms.ComboBox cmb_MaterialType;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Employee;
        private System.Windows.Forms.ComboBox cmb_Facility;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_SerialNumber;
        private System.Windows.Forms.TextBox txt_DeviceModel;
        private System.Windows.Forms.TextBox txt_Cpu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Ram;
        private System.Windows.Forms.TextBox txt_DiskSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_EstimatedLife;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp_ActivationDate;
        private System.Windows.Forms.DateTimePicker dtp_AssignmentDate;
        private System.Windows.Forms.TextBox txt_Notes;
    }
}