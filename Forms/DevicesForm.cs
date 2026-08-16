using InventoryManagementSystem.DAL;
using InventoryManagementSystem.Models;
using InventoryTracking.Models;
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
    public partial class DevicesForm : Form
    {
        public DevicesForm()
        {
            InitializeComponent();
        }

        private void DevicesForm_Load(object sender, EventArgs e)
        {
            LoadDevices();
        }

        private void LoadDevices()
        {
            DeviceRepository repository = new DeviceRepository();

            dgv_Devices.DataSource = repository.GetAllDevices();

            dgv_Devices.Columns["Id"].Visible = false;
        }

        private void SearchDevices()
        {
            DeviceRepository repository = new DeviceRepository();

            dgv_Devices.DataSource = repository.SearchDevices(txt_Search.Text);

            dgv_Devices.Columns["Id"].Visible = false;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddDeviceForm form = new AddDeviceForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadDevices();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_EditDevice_Click(object sender, EventArgs e)
        {
            if (dgv_Devices.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Lütfen düzenlemek istediğiniz cihazı seçiniz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int deviceId = Convert.ToInt32(dgv_Devices.SelectedRows[0].Cells["Id"].Value);

            DeviceRepository repository = new DeviceRepository();

            Device device = repository.GetDeviceById(deviceId);

            if (device == null)
            {
                MessageBox.Show(
                    "Cihaz bulunamadı.",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            AddDeviceForm form = new AddDeviceForm(device);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadDevices();
            }
        }

        private void btn_DeleteDevice_Click(object sender, EventArgs e)
        {
            if (dgv_Devices.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Lütfen silmek istediğiniz cihazı seçiniz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int deviceId = Convert.ToInt32(dgv_Devices.SelectedRows[0].Cells["Id"].Value);

            DialogResult result = MessageBox.Show(
                "Seçili cihazı silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            DeviceRepository repository = new DeviceRepository();

            Device oldDevice = repository.GetDeviceById(deviceId);

            repository.DeleteDevice(deviceId);

            DeviceMovement movement = new DeviceMovement();

            movement.DeviceId = deviceId;

            movement.MovementType = "Silindi";

            movement.FromEmployeeId = oldDevice.EmployeeId;
            movement.ToEmployeeId = null;

            movement.FromFacilityId = oldDevice.FacilityId;
            movement.ToFacilityId = oldDevice.FacilityId;

            movement.FromStatusId = oldDevice.StatusId;
            movement.ToStatusId = oldDevice.StatusId;

            movement.Description = null;

            movement.MovementDate = DateTime.Now;

            DeviceMovementRepository movementRepository = new DeviceMovementRepository();

            movementRepository.AddMovement(movement);

            MessageBox.Show(
                "Cihaz başarıyla silindi.",
                "Bilgi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadDevices();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            SearchDevices();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
