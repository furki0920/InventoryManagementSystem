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
    public partial class EmployeeDevicesForm : Form
    {
        private readonly DeviceRepository repository = new DeviceRepository();

        private readonly int employeeId;

        private readonly string employeeName;

        public EmployeeDevicesForm(int employeeId, string employeeName)
        {
            InitializeComponent();

            this.employeeId = employeeId;

            this.employeeName = employeeName;
        }

        private void EmployeeDevicesForm_Load(object sender, EventArgs e)
        {
            this.Text = employeeName + "Zimmetli Cihazlar";

            LoadDevices();
        }

        private void LoadDevices()
        {
            dgv_Devices.DataSource =
                repository.GetDevicesByEmployee(employeeId);

            dgv_Devices.Columns["Brand"].HeaderText = "Marka";

            dgv_Devices.Columns["DeviceModel"].HeaderText = "Model";

            dgv_Devices.Columns["SerialNumber"].HeaderText = "Seri No";

            dgv_Devices.Columns["Facility"].HeaderText = "Tesis";

            dgv_Devices.Columns["Status"].HeaderText = "Durum";

            lbl_Total.Text =
                "Toplam Aktif Cihaz : " + dgv_Devices.Rows.Count;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
