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
    public partial class AddFacilityForm : Form
    {
        private bool isEditMode = false;

        private Facility editingFacility = null;
        public AddFacilityForm()
        {
            InitializeComponent();
            this.Text = "Tesis Ekle";
        }

        public AddFacilityForm(Facility facility)
        {

            InitializeComponent();
            this.Text = "Tesis Düzenle";

            isEditMode = true;

            editingFacility = facility;
        }

        private void AddFacilityForm_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                this.Text = "Tesis Düzenle";

                txt_Name.Text = editingFacility.Name;
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show(
                    "Tesis adı boş bırakılamaz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txt_Name.Focus();

                return;
            }

            Facility facility = new Facility();

            facility.Name = txt_Name.Text.Trim();

            FacilityRepository repository = new FacilityRepository();

            if (isEditMode)
            {
                if (repository.FacilityExists(facility.Name, editingFacility.Id))
                {
                    MessageBox.Show(
                        "Bu tesis zaten kayıtlı.",
                        "Uyarı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txt_Name.Focus();

                    return;
                }

                facility.Id = editingFacility.Id;

                repository.UpdateFacility(facility);

                MessageBox.Show(
                    "Tesis başarıyla güncellendi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                Facility deletedFacility = repository.GetDeletedFacility(facility.Name);

                if (deletedFacility != null)
                {
                    repository.RestoreFacility(deletedFacility.Id);

                    MessageBox.Show(
                        "Tesis daha önce silinmişti. Tekrar aktif edildi.",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    if (repository.FacilityExists(facility.Name))
                    {
                        MessageBox.Show(
                            "Bu tesis zaten kayıtlı.",
                            "Uyarı",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txt_Name.Focus();

                        return;
                    }

                    repository.AddFacility(facility);

                    MessageBox.Show(
                        "Tesis başarıyla eklendi.",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
