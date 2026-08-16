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
    public partial class AddBrandForm : Form
    {

        private bool isEditMode = false;
        private Brand editingBrand = null;

        public AddBrandForm()
        {
            InitializeComponent();
            this.Text = "Marka Ekle";
        }

        public AddBrandForm(Brand brand)
        {
            InitializeComponent();
            this.Text = "Marka Düzenle";

            isEditMode = true;

            editingBrand = brand;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show(
                    "Marka adı boş bırakılamaz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txt_Name.Focus();

                return;
            }

            Brand brand = new Brand();

            brand.Name = txt_Name.Text.Trim();

            BrandRepository repository = new BrandRepository();

            if (!isEditMode && repository.BrandExists(txt_Name.Text.Trim()))
            {
                MessageBox.Show(
                    "Bu marka zaten kayıtlı.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txt_Name.Focus();

                return;
            }

            if (isEditMode)
            {
                if (repository.BrandExists(brand.Name, editingBrand.Id))
                {
                    MessageBox.Show(
                        "Bu marka zaten kayıtlı.",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txt_Name.Focus();

                    return;
                }

                brand.Id = editingBrand.Id;

                repository.UpdateBrand(brand);

                MessageBox.Show(
                    "Marka başarıyla güncellendi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                Brand deletedBrand = repository.GetDeletedBrand(brand.Name);

                if (deletedBrand != null)
                {
                    repository.RestoreBrand(deletedBrand.Id);

                    MessageBox.Show(
                        "Marka daha önce silinmişti. Tekrar aktif edildi.",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    repository.AddBrand(brand);

                    MessageBox.Show(
                        "Marka başarıyla eklendi.",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void AddBrandForm_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                this.Text = "Marka Düzenle";

                txt_Name.Text = editingBrand.Name;
            }
        }
    }
}
