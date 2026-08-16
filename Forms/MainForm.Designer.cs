namespace InventoryManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_StockMovements = new System.Windows.Forms.Button();
            this.btn_Facilities = new System.Windows.Forms.Button();
            this.btn_Brands = new System.Windows.Forms.Button();
            this.btn_Employees = new System.Windows.Forms.Button();
            this.btn_Devices = new System.Windows.Forms.Button();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(163)))), ((int)(((byte)(59)))));
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("Yu Gothic UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(1083, 89);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "ENVANTER TAKİP SİSTEMİ";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.pnl_Menu.Controls.Add(this.pic_Logo);
            this.pnl_Menu.Controls.Add(this.btn_Exit);
            this.pnl_Menu.Controls.Add(this.btn_StockMovements);
            this.pnl_Menu.Controls.Add(this.btn_Facilities);
            this.pnl_Menu.Controls.Add(this.btn_Brands);
            this.pnl_Menu.Controls.Add(this.btn_Employees);
            this.pnl_Menu.Controls.Add(this.btn_Devices);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 89);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(1083, 544);
            this.pnl_Menu.TabIndex = 1;
            this.pnl_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Menu_Paint);
            this.pnl_Menu.Resize += new System.EventHandler(this.MainForm_Resize);
            // 
            // pic_Logo
            // 
            this.pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_Logo.Image")));
            this.pic_Logo.Location = new System.Drawing.Point(309, 16);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(439, 123);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 6;
            this.pic_Logo.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(226)))));
            this.btn_Exit.Location = new System.Drawing.Point(611, 422);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(250, 100);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Çıkış";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_StockMovements
            // 
            this.btn_StockMovements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_StockMovements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.btn_StockMovements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StockMovements.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_StockMovements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(226)))));
            this.btn_StockMovements.Location = new System.Drawing.Point(611, 291);
            this.btn_StockMovements.Name = "btn_StockMovements";
            this.btn_StockMovements.Size = new System.Drawing.Size(250, 100);
            this.btn_StockMovements.TabIndex = 4;
            this.btn_StockMovements.Text = "Cihaz Hareketleri";
            this.btn_StockMovements.UseVisualStyleBackColor = false;
            this.btn_StockMovements.Click += new System.EventHandler(this.btn_StockMovements_Click);
            // 
            // btn_Facilities
            // 
            this.btn_Facilities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Facilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.btn_Facilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Facilities.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Facilities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(226)))));
            this.btn_Facilities.Location = new System.Drawing.Point(611, 154);
            this.btn_Facilities.Name = "btn_Facilities";
            this.btn_Facilities.Size = new System.Drawing.Size(250, 100);
            this.btn_Facilities.TabIndex = 3;
            this.btn_Facilities.Text = "Tesisler";
            this.btn_Facilities.UseVisualStyleBackColor = false;
            this.btn_Facilities.Click += new System.EventHandler(this.btn_Facilities_Click);
            // 
            // btn_Brands
            // 
            this.btn_Brands.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Brands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.btn_Brands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Brands.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Brands.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(226)))));
            this.btn_Brands.Location = new System.Drawing.Point(221, 422);
            this.btn_Brands.Name = "btn_Brands";
            this.btn_Brands.Size = new System.Drawing.Size(250, 100);
            this.btn_Brands.TabIndex = 2;
            this.btn_Brands.Text = "Markalar";
            this.btn_Brands.UseVisualStyleBackColor = false;
            this.btn_Brands.Click += new System.EventHandler(this.btn_Brands_Click);
            // 
            // btn_Employees
            // 
            this.btn_Employees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.btn_Employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Employees.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Employees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(226)))));
            this.btn_Employees.Location = new System.Drawing.Point(221, 291);
            this.btn_Employees.Name = "btn_Employees";
            this.btn_Employees.Size = new System.Drawing.Size(250, 100);
            this.btn_Employees.TabIndex = 1;
            this.btn_Employees.Text = "Personeller";
            this.btn_Employees.UseVisualStyleBackColor = false;
            this.btn_Employees.Click += new System.EventHandler(this.btn_Employees_Click);
            // 
            // btn_Devices
            // 
            this.btn_Devices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Devices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(74)))), ((int)(((byte)(97)))));
            this.btn_Devices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Devices.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Devices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(226)))));
            this.btn_Devices.Location = new System.Drawing.Point(221, 154);
            this.btn_Devices.Name = "btn_Devices";
            this.btn_Devices.Size = new System.Drawing.Size(250, 100);
            this.btn_Devices.TabIndex = 0;
            this.btn_Devices.Text = "Cihazlar";
            this.btn_Devices.UseVisualStyleBackColor = false;
            this.btn_Devices.Click += new System.EventHandler(this.btn_Devices_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 633);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.lbl_Title);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envanter Takip Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_StockMovements;
        private System.Windows.Forms.Button btn_Facilities;
        private System.Windows.Forms.Button btn_Brands;
        private System.Windows.Forms.Button btn_Employees;
        private System.Windows.Forms.Button btn_Devices;
        private System.Windows.Forms.PictureBox pic_Logo;
    }
}

