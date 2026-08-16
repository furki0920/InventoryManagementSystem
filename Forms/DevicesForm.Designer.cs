namespace InventoryManagementSystem.Forms
{
    partial class DevicesForm
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.btn_DeleteDevice = new System.Windows.Forms.Button();
            this.btn_EditDevice = new System.Windows.Forms.Button();
            this.dgv_Devices = new System.Windows.Forms.DataGridView();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Devices)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 62);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Yeni Cihaz";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(59)))));
            this.pnl_Top.Controls.Add(this.btn_Close);
            this.pnl_Top.Controls.Add(this.txt_Search);
            this.pnl_Top.Controls.Add(this.lbl_Search);
            this.pnl_Top.Controls.Add(this.btn_DeleteDevice);
            this.pnl_Top.Controls.Add(this.btn_EditDevice);
            this.pnl_Top.Controls.Add(this.btn_Add);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(800, 144);
            this.pnl_Top.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Location = new System.Drawing.Point(535, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(120, 62);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "Kapat";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(64, 90);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(320, 26);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.lbl_Search.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_Search.Location = new System.Drawing.Point(20, 93);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(38, 20);
            this.lbl_Search.TabIndex = 4;
            this.lbl_Search.Text = "Ara ";
            // 
            // btn_DeleteDevice
            // 
            this.btn_DeleteDevice.Location = new System.Drawing.Point(264, 12);
            this.btn_DeleteDevice.Name = "btn_DeleteDevice";
            this.btn_DeleteDevice.Size = new System.Drawing.Size(120, 62);
            this.btn_DeleteDevice.TabIndex = 3;
            this.btn_DeleteDevice.Text = "Cihazı Sil";
            this.btn_DeleteDevice.UseVisualStyleBackColor = true;
            this.btn_DeleteDevice.Click += new System.EventHandler(this.btn_DeleteDevice_Click);
            // 
            // btn_EditDevice
            // 
            this.btn_EditDevice.Location = new System.Drawing.Point(138, 12);
            this.btn_EditDevice.Name = "btn_EditDevice";
            this.btn_EditDevice.Size = new System.Drawing.Size(120, 62);
            this.btn_EditDevice.TabIndex = 2;
            this.btn_EditDevice.Text = "Cihaz Düzenle";
            this.btn_EditDevice.UseVisualStyleBackColor = true;
            this.btn_EditDevice.Click += new System.EventHandler(this.btn_EditDevice_Click);
            // 
            // dgv_Devices
            // 
            this.dgv_Devices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Devices.Location = new System.Drawing.Point(0, 144);
            this.dgv_Devices.MultiSelect = false;
            this.dgv_Devices.Name = "dgv_Devices";
            this.dgv_Devices.ReadOnly = true;
            this.dgv_Devices.RowHeadersWidth = 62;
            this.dgv_Devices.RowTemplate.Height = 28;
            this.dgv_Devices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Devices.Size = new System.Drawing.Size(800, 306);
            this.dgv_Devices.TabIndex = 3;
            // 
            // DevicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Devices);
            this.Controls.Add(this.pnl_Top);
            this.Name = "DevicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cihaz Yönetimi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DevicesForm_Load);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Devices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.DataGridView dgv_Devices;
        private System.Windows.Forms.Button btn_EditDevice;
        private System.Windows.Forms.Button btn_DeleteDevice;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Close;
    }
}