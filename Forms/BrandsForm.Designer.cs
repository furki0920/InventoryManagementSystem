namespace InventoryManagementSystem.Forms
{
    partial class BrandsForm
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
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.pnl_Bot = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Brands = new System.Windows.Forms.DataGridView();
            this.pnl_Top.SuspendLayout();
            this.pnl_Bot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Brands)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(59)))));
            this.pnl_Top.Controls.Add(this.txt_Search);
            this.pnl_Top.Controls.Add(this.lbl_Search);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(800, 73);
            this.pnl_Top.TabIndex = 0;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(102, 25);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(219, 26);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.lbl_Search.ForeColor = System.Drawing.Color.White;
            this.lbl_Search.Location = new System.Drawing.Point(62, 28);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(34, 20);
            this.lbl_Search.TabIndex = 0;
            this.lbl_Search.Text = "Ara";
            // 
            // pnl_Bot
            // 
            this.pnl_Bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.pnl_Bot.Controls.Add(this.btn_Cancel);
            this.pnl_Bot.Controls.Add(this.btn_Delete);
            this.pnl_Bot.Controls.Add(this.btn_Edit);
            this.pnl_Bot.Controls.Add(this.btn_Add);
            this.pnl_Bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bot.Location = new System.Drawing.Point(0, 370);
            this.pnl_Bot.Name = "pnl_Bot";
            this.pnl_Bot.Size = new System.Drawing.Size(800, 80);
            this.pnl_Bot.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(653, 22);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(86, 34);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "İptal";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(276, 22);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(86, 34);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(171, 22);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(86, 34);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "Düzenle";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(66, 22);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(86, 34);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Brands
            // 
            this.dgv_Brands.AllowUserToAddRows = false;
            this.dgv_Brands.AllowUserToDeleteRows = false;
            this.dgv_Brands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Brands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Brands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Brands.Location = new System.Drawing.Point(0, 73);
            this.dgv_Brands.MultiSelect = false;
            this.dgv_Brands.Name = "dgv_Brands";
            this.dgv_Brands.ReadOnly = true;
            this.dgv_Brands.RowHeadersWidth = 62;
            this.dgv_Brands.RowTemplate.Height = 28;
            this.dgv_Brands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Brands.Size = new System.Drawing.Size(800, 297);
            this.dgv_Brands.TabIndex = 2;
            // 
            // BrandsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Brands);
            this.Controls.Add(this.pnl_Bot);
            this.Controls.Add(this.pnl_Top);
            this.Name = "BrandsForm";
            this.Text = "Marka Yönetimi";
            this.Load += new System.EventHandler(this.BrandsForm_Load);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            this.pnl_Bot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Brands)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel pnl_Bot;
        private System.Windows.Forms.DataGridView dgv_Brands;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Add;
    }
}