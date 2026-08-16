namespace InventoryManagementSystem.Forms
{
    partial class DeviceMovementsForm
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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.dgv_DeviceMovements = new System.Windows.Forms.DataGridView();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DeviceMovements)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(59)))));
            this.pnl_Top.Controls.Add(this.btn_Close);
            this.pnl_Top.Controls.Add(this.txt_Search);
            this.pnl_Top.Controls.Add(this.lbl_Search);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(800, 78);
            this.pnl_Top.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Location = new System.Drawing.Point(538, 19);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(120, 44);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Kapat";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(68, 28);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(291, 26);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.lbl_Search.ForeColor = System.Drawing.Color.White;
            this.lbl_Search.Location = new System.Drawing.Point(28, 31);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(34, 20);
            this.lbl_Search.TabIndex = 0;
            this.lbl_Search.Text = "Ara";
            // 
            // dgv_DeviceMovements
            // 
            this.dgv_DeviceMovements.AllowUserToAddRows = false;
            this.dgv_DeviceMovements.AllowUserToDeleteRows = false;
            this.dgv_DeviceMovements.AllowUserToResizeRows = false;
            this.dgv_DeviceMovements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DeviceMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DeviceMovements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DeviceMovements.Location = new System.Drawing.Point(0, 78);
            this.dgv_DeviceMovements.MultiSelect = false;
            this.dgv_DeviceMovements.Name = "dgv_DeviceMovements";
            this.dgv_DeviceMovements.ReadOnly = true;
            this.dgv_DeviceMovements.RowHeadersVisible = false;
            this.dgv_DeviceMovements.RowHeadersWidth = 62;
            this.dgv_DeviceMovements.RowTemplate.Height = 28;
            this.dgv_DeviceMovements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DeviceMovements.Size = new System.Drawing.Size(800, 372);
            this.dgv_DeviceMovements.TabIndex = 2;
            // 
            // DeviceMovementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_DeviceMovements);
            this.Controls.Add(this.pnl_Top);
            this.Name = "DeviceMovementsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cihaz Hareketleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeviceMovementsForm_Load);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DeviceMovements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.DataGridView dgv_DeviceMovements;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Close;
    }
}