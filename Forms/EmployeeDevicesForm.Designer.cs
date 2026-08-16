namespace InventoryManagementSystem.Forms
{
    partial class EmployeeDevicesForm
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
            this.pnl_Bot = new System.Windows.Forms.Panel();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.dgv_Devices = new System.Windows.Forms.DataGridView();
            this.pnl_Bot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Devices)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Bot
            // 
            this.pnl_Bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.pnl_Bot.Controls.Add(this.lbl_Total);
            this.pnl_Bot.Controls.Add(this.btn_Close);
            this.pnl_Bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bot.Location = new System.Drawing.Point(0, 370);
            this.pnl_Bot.Name = "pnl_Bot";
            this.pnl_Bot.Size = new System.Drawing.Size(800, 80);
            this.pnl_Bot.TabIndex = 4;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(59)))));
            this.lbl_Total.ForeColor = System.Drawing.Color.White;
            this.lbl_Total.Location = new System.Drawing.Point(37, 29);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(162, 20);
            this.lbl_Total.TabIndex = 4;
            this.lbl_Total.Text = "Toplam Aktif Cihaz : 0";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(653, 22);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(86, 34);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Kapat";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(59)))));
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(800, 73);
            this.pnl_Top.TabIndex = 3;
            // 
            // dgv_Devices
            // 
            this.dgv_Devices.AllowUserToAddRows = false;
            this.dgv_Devices.AllowUserToDeleteRows = false;
            this.dgv_Devices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Devices.Location = new System.Drawing.Point(0, 73);
            this.dgv_Devices.MultiSelect = false;
            this.dgv_Devices.Name = "dgv_Devices";
            this.dgv_Devices.ReadOnly = true;
            this.dgv_Devices.RowHeadersWidth = 62;
            this.dgv_Devices.RowTemplate.Height = 28;
            this.dgv_Devices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Devices.Size = new System.Drawing.Size(800, 297);
            this.dgv_Devices.TabIndex = 6;
            // 
            // EmployeeDevicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Devices);
            this.Controls.Add(this.pnl_Bot);
            this.Controls.Add(this.pnl_Top);
            this.Name = "EmployeeDevicesForm";
            this.Text = "EmployeeDevicesForm";
            this.Load += new System.EventHandler(this.EmployeeDevicesForm_Load);
            this.pnl_Bot.ResumeLayout(false);
            this.pnl_Bot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Devices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Bot;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.DataGridView dgv_Devices;
    }
}