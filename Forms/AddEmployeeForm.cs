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
    public partial class AddEmployeeForm : Form
    {
        private readonly EmployeeRepository employeeRepository = new EmployeeRepository();

        private int employeeId = 0;
        private bool isEditMode = false;
        public AddEmployeeForm()
        {
            InitializeComponent();

            this.Text = "Personel Ekle";
        }

        public AddEmployeeForm(int employeeId)
        {
            InitializeComponent();
            this.Text = "Personel Düzenle";
            this.employeeId = employeeId;
            isEditMode = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string fullName = txt_FullName.Text.Trim();
            string email = txt_Email.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show(
                    "Ad Soyad alanı boş bırakılamaz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (isEditMode)
            {
                if (!string.IsNullOrWhiteSpace(email))
                {
                    if (employeeRepository.EmployeeEmailExists(email, employeeId))
                    {
                        MessageBox.Show(
                            "Bu e-posta adresi başka bir personele aittir.",
                            "Uyarı",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }
                }

                employeeRepository.UpdateEmployee(employeeId, fullName, email);

                MessageBox.Show(
                    "Personel başarıyla güncellendi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                Employee deletedEmployee = employeeRepository.GetDeletedEmployee(fullName);

                if (deletedEmployee != null)
                {
                    employeeRepository.RestoreEmployee(deletedEmployee.Id);

                    MessageBox.Show(
                        "Personel daha önce silinmişti. Tekrar aktif edildi.",
                        "Bilgi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(email))
                    {
                        if (employeeRepository.EmployeeEmailExists(email))
                        {
                            MessageBox.Show(
                                "Bu e-posta adresi başka bir personele aittir.",
                                "Uyarı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }

                    employeeRepository.AddEmployee(fullName, email);

                    MessageBox.Show(
                        "Personel başarıyla eklendi.",
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

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                LoadEmployee();
            }
        }

        private void LoadEmployee()
        {
            Employee employee = employeeRepository.GetEmployeeById(employeeId);

            if (employee == null)
            {
                MessageBox.Show(
                    "Personel bulunamadı.",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.Close();

                return;
            }

            txt_FullName.Text = employee.FullName;
            txt_Email.Text = employee.Email;
        }




    }
}
