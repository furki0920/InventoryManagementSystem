using InventoryManagementSystem.DAL;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class BrandsForm : Form
    {
        public BrandsForm()
        {
            InitializeComponent();
        }

        private void BrandsForm_Load(object sender, EventArgs e)
        {
            BrandRepository repository = new BrandRepository();

            dgv_Brands.DataSource = repository.GetAllBrands();

            dgv_Brands.Columns["Id"].Visible = false;

            dgv_Brands.Columns["Name"].HeaderText = "Marka";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddBrandForm form = new AddBrandForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                BrandRepository repository = new BrandRepository();

                dgv_Brands.DataSource = repository.GetAllBrands();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Brands.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Lütfen düzenlemek istediğiniz markayı seçiniz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int brandId = Convert.ToInt32(
                dgv_Brands.SelectedRows[0].Cells["Id"].Value);

            BrandRepository repository = new BrandRepository();

            Brand brand = repository.GetBrandById(brandId);

            AddBrandForm form = new AddBrandForm(brand);

            if (form.ShowDialog() == DialogResult.OK)
            {
                dgv_Brands.DataSource = repository.GetAllBrands();
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            BrandRepository repository = new BrandRepository();

            dgv_Brands.DataSource = repository.SearchBrands(txt_Search.Text.Trim());

            dgv_Brands.Columns["Id"].Visible = false;

            dgv_Brands.Columns["Name"].HeaderText = "Marka";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Brands.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Lütfen silmek istediğiniz markayı seçiniz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int brandId = Convert.ToInt32(
                dgv_Brands.SelectedRows[0].Cells["Id"].Value);

            DialogResult result = MessageBox.Show(
                "Seçili markayı silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            BrandRepository repository = new BrandRepository();

            repository.DeleteBrand(brandId);

            MessageBox.Show(
                "Marka başarıyla silindi.",
                "Bilgi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            dgv_Brands.DataSource = repository.GetAllBrands();

            dgv_Brands.Columns["Id"].Visible = false;

            dgv_Brands.Columns["Name"].HeaderText = "Marka";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
