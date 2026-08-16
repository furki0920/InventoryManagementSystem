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
    public partial class FacilitiesForm : Form
    {
        private FacilityRepository repository = new FacilityRepository();

        private void FacilitiesForm_Load(object sender, EventArgs e)
        {
            LoadFacilities();
        }

        private void LoadFacilities()
        {
            dgv_Facilities.DataSource = repository.GetAllFacilities();

            dgv_Facilities.Columns["Id"].Visible = false;

            dgv_Facilities.Columns["Name"].HeaderText = "Tesis";
        }
        public FacilitiesForm()
        {
            InitializeComponent();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            dgv_Facilities.DataSource =
                repository.SearchFacilities(txt_Search.Text.Trim());

            dgv_Facilities.Columns["Id"].Visible = false;

            dgv_Facilities.Columns["Name"].HeaderText = "Tesis";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddFacilityForm form = new AddFacilityForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadFacilities();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Facilities.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Lütfen düzenlemek istediğiniz tesisi seçiniz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int id = Convert.ToInt32(
                dgv_Facilities.SelectedRows[0].Cells["Id"].Value);

            Facility facility = repository.GetFacilityById(id);

            AddFacilityForm form = new AddFacilityForm(facility);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadFacilities();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Facilities.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Lütfen silmek istediğiniz tesisi seçiniz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int id = Convert.ToInt32(
                dgv_Facilities.SelectedRows[0].Cells["Id"].Value);

            DialogResult result = MessageBox.Show(
                "Seçili tesisi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            repository.DeleteFacility(id);

            MessageBox.Show(
                "Tesis başarıyla silindi.",
                "Bilgi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadFacilities();
        }
    }
}
