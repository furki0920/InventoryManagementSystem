using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.DAL;

namespace InventoryManagementSystem.Forms
{
    public partial class EmployeesForm : Form
    {
        private EmployeeRepository repository = new EmployeeRepository();
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            dgv_Employees.DataSource = repository.GetAllEmployees();

            dgv_Employees.Columns["Id"].Visible = false;

            dgv_Employees.Columns["FullName"].HeaderText = "Personel";

            dgv_Employees.Columns["Email"].HeaderText = "E-Posta";
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            dgv_Employees.DataSource =
                repository.SearchEmployees(txt_Search.Text.Trim());

            dgv_Employees.Columns["Id"].Visible = false;

            dgv_Employees.Columns["FullName"].HeaderText = "Personel";

            dgv_Employees.Columns["Email"].HeaderText = "E-Posta";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Employees.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Lütfen düzenlemek istediğiniz personeli seçiniz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int employeeId = Convert.ToInt32(
                dgv_Employees.SelectedRows[0].Cells["Id"].Value);

            AddEmployeeForm form = new AddEmployeeForm(employeeId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadEmployees();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Employees.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Lütfen silmek istediğiniz personeli seçiniz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int employeeId = Convert.ToInt32(
                dgv_Employees.SelectedRows[0].Cells["Id"].Value);

            if (repository.HasAssignedDevices(employeeId))
            {
                MessageBox.Show(
                    "Bu personelin üzerinde aktif zimmetli cihaz bulunmaktadır.\n\nLütfen önce cihazların zimmetini kaldırınız.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                "Seçili personeli silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            repository.DeleteEmployee(employeeId);

            MessageBox.Show(
                "Personel başarıyla silindi.",
                "Bilgi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadEmployees();
        }

        private void btn_EmployeeDevices_Click(object sender, EventArgs e)
        {
            if (dgv_Employees.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Lütfen bir personel seçiniz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int employeeId = Convert.ToInt32(
                dgv_Employees.SelectedRows[0].Cells["Id"].Value);

            string employeeName =
                dgv_Employees.SelectedRows[0].Cells["FullName"].Value.ToString();

            EmployeeDevicesForm form =
                new EmployeeDevicesForm(employeeId, employeeName);

            form.ShowDialog();
        }
    }
}
