using InventoryManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            CenterLogo();
        }

        private void CenterLogo()
        {
            // Üst başlığın altı
            int alanUstu = lbl_Title.Bottom;

            // İlk butonun üstü
            int alanAlti = btn_Facilities.Top;

            // İki alan arasındaki boşluk
            int alanYuksekligi = alanAlti - alanUstu;

            // Boşluğun %80'i kadar logo
            int logoSize = (int)(alanYuksekligi * 0.9);

            // Logo çok büyümesin
            if (logoSize > 140)
                logoSize = 140;

            // Logo çok küçülmesin
            if (logoSize < 60)
                logoSize = 60;

            pic_Logo.Width = logoSize;
            pic_Logo.Height = logoSize;

            // Yatayda ortala
            pic_Logo.Left =
                (this.ClientSize.Width - pic_Logo.Width) / 2;

            // Başlık ile ilk buton arasına dikey olarak ortala
            pic_Logo.Top =
                alanUstu +
                (alanYuksekligi - pic_Logo.Height) / 4;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = Helpers.Database.GetConnection())
                {
                    connection.Open();

                    MessageBox.Show(
                        "SQL Server bağlantısı başarılı!",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Bağlantı Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void pnl_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Devices_Click(object sender, EventArgs e)
        {
            DevicesForm devicesForm = new DevicesForm();
            devicesForm.ShowDialog();
        }

        private void btn_StockMovements_Click(object sender, EventArgs e)
        {
            DeviceMovementsForm form = new DeviceMovementsForm();

            form.ShowDialog();
        }

        private void btn_Brands_Click(object sender, EventArgs e)
        {
            BrandsForm form = new BrandsForm();

            form.ShowDialog();
        }

        private void btn_Facilities_Click(object sender, EventArgs e)
        {
            FacilitiesForm form = new FacilitiesForm();

            form.ShowDialog();
        }

        private void btn_Employees_Click(object sender, EventArgs e)
        {
            EmployeesForm form = new EmployeesForm();

            form.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Programdan çıkmak istediğinize emin misiniz?",
                "Çıkış",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterLogo();
        }
    }
}
