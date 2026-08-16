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
    public partial class AddDeviceForm : Form
    {
        private Device editingDevice = null;
        private bool isEditMode = false;

        public AddDeviceForm()
        {
            InitializeComponent();
        }

        public AddDeviceForm(Device device)
        {
            InitializeComponent();

            editingDevice = device;

            isEditMode = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddDeviceForm addDeviceForm = new AddDeviceForm();
            addDeviceForm.ShowDialog();
        }
        private void AddDeviceForm_Load(object sender, EventArgs e)
        {
            DeviceRepository repository = new DeviceRepository();

            // Brand
            cmb_Brand.DataSource = repository.GetBrands();
            cmb_Brand.DisplayMember = "Name";
            cmb_Brand.ValueMember = "Id";

            // Material Type
            cmb_MaterialType.DataSource = repository.GetMaterialTypes();
            cmb_MaterialType.DisplayMember = "Name";
            cmb_MaterialType.ValueMember = "Id";
            
            // Employee
            cmb_Employee.DataSource = repository.GetEmployees();
            cmb_Employee.DisplayMember = "FullName";
            cmb_Employee.ValueMember = "Id";

            // Facility
            cmb_Facility.DataSource = repository.GetFacilities();
            cmb_Facility.DisplayMember = "Name";
            cmb_Facility.ValueMember = "Id";

            // Status
            cmb_Status.DataSource = repository.GetStatuses();
            cmb_Status.DisplayMember = "Name";
            cmb_Status.ValueMember = "Id";

            if (isEditMode)
            {
                this.Text = "Cihaz Düzenle";

                txt_SerialNumber.Text = editingDevice.SerialNumber;
                txt_DeviceModel.Text = editingDevice.DeviceModel;
                txt_Cpu.Text = editingDevice.Cpu;
                txt_Ram.Text = editingDevice.Ram;
                txt_DiskSize.Text = editingDevice.DiskSize;
                txt_EstimatedLife.Text = editingDevice.EstimatedLife;
                txt_Notes.Text = editingDevice.Notes;

                cmb_Brand.SelectedValue = editingDevice.BrandId;
                cmb_MaterialType.SelectedValue = editingDevice.MaterialTypeId;
                cmb_Facility.SelectedValue = editingDevice.FacilityId;
                cmb_Status.SelectedValue = editingDevice.StatusId;

                if (editingDevice.EmployeeId.HasValue)
                    cmb_Employee.SelectedValue = editingDevice.EmployeeId.Value;

                if (editingDevice.ActivationDate.HasValue)
                    dtp_ActivationDate.Value = editingDevice.ActivationDate.Value;

                if (editingDevice.AssignmentDate.HasValue)
                    dtp_AssignmentDate.Value = editingDevice.AssignmentDate.Value;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Device device = new Device();

            device.BrandId = Convert.ToInt32(cmb_Brand.SelectedValue);

            device.MaterialTypeId = Convert.ToInt32(cmb_MaterialType.SelectedValue);

            device.FacilityId = Convert.ToInt32(cmb_Facility.SelectedValue);

            device.StatusId = Convert.ToInt32(cmb_Status.SelectedValue);

            if (cmb_Employee.SelectedValue != null)
            {
                device.EmployeeId = Convert.ToInt32(cmb_Employee.SelectedValue);
            }
            else
            {
                device.EmployeeId = null;
            }
            device.SerialNumber = txt_SerialNumber.Text.Trim();

            device.DeviceModel = txt_DeviceModel.Text.Trim();

            device.Cpu = txt_Cpu.Text.Trim();

            device.Ram = txt_Ram.Text.Trim();

            device.DiskSize = txt_DiskSize.Text.Trim();

            device.EstimatedLife = txt_EstimatedLife.Text.Trim();

            device.Notes = txt_Notes.Text.Trim();

            device.ActivationDate = dtp_ActivationDate.Value;

            device.AssignmentDate = dtp_AssignmentDate.Value;

            DeviceRepository repository = new DeviceRepository();

            if (!isEditMode && repository.DeviceExists(device.SerialNumber))
            {
                MessageBox.Show(
                    "Bu seri numarasına sahip aktif bir cihaz zaten kayıtlı.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txt_SerialNumber.Focus();

                return;
            }

            if (isEditMode)
            {
                device.Id = editingDevice.Id;

                Device oldDevice = repository.GetDeviceById(device.Id);

                repository.UpdateDevice(device);

                DeviceMovementRepository movementRepository = new DeviceMovementRepository();

                if (oldDevice.EmployeeId != device.EmployeeId)
                {
                    DeviceMovement movement = new DeviceMovement();

                    movement.DeviceId = device.Id;

                    movement.MovementType = "Zimmet Verildi";

                    movement.FromEmployeeId = oldDevice.EmployeeId;
                    movement.ToEmployeeId = device.EmployeeId;

                    movement.FromFacilityId = oldDevice.FacilityId;
                    movement.ToFacilityId = device.FacilityId;

                    movement.FromStatusId = oldDevice.StatusId;
                    movement.ToStatusId = device.StatusId;

                    movement.Description = "Personel değiştirildi.";

                    movement.MovementDate = DateTime.Now;

                    movementRepository.AddMovement(movement);
                }

                if (oldDevice.FacilityId != device.FacilityId)
                {
                    DeviceMovement movement = new DeviceMovement();

                    movement.DeviceId = device.Id;

                    movement.MovementType = "Tesis Değiştirildi";

                    movement.FromEmployeeId = device.EmployeeId;
                    movement.ToEmployeeId = device.EmployeeId;

                    movement.FromFacilityId = oldDevice.FacilityId;
                    movement.ToFacilityId = device.FacilityId;

                    movement.FromStatusId = device.StatusId;
                    movement.ToStatusId = device.StatusId;

                    movement.Description = "Cihaz başka bir tesise transfer edildi.";

                    movement.MovementDate = DateTime.Now;

                    movementRepository.AddMovement(movement);
                }

                if (oldDevice.StatusId != device.StatusId)
                {
                    DeviceMovement movement = new DeviceMovement();

                    movement.DeviceId = device.Id;

                    movement.MovementType =
                        GetStatusMovementType(oldDevice.StatusId, device.StatusId);

                    movement.FromEmployeeId = oldDevice.EmployeeId;
                    movement.ToEmployeeId = device.EmployeeId;

                    movement.FromFacilityId = oldDevice.FacilityId;
                    movement.ToFacilityId = device.FacilityId;

                    movement.FromStatusId = oldDevice.StatusId;
                    movement.ToStatusId = device.StatusId;

                    movement.Description = null;

                    movement.MovementDate = DateTime.Now;

                    movementRepository.AddMovement(movement);
                }

                MessageBox.Show(
                    "Cihaz başarıyla güncellendi.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }

            else
            {
                try
                {
                    // Önce pasif cihaz var mı kontrol et
                    Device deletedDevice =
                        repository.GetDeletedDevice(device.SerialNumber);

                    if (deletedDevice != null)
                    {
                        // Pasif cihazı tekrar aktif hale getir
                        device.Id = deletedDevice.Id;

                        repository.RestoreDevice(device.Id);

                        // Eski kaydın bilgilerini yeni girilen bilgilerle güncelle
                        repository.UpdateDevice(device);

                        MessageBox.Show(
                            "Cihaz daha önce silinmişti. Tekrar aktif edildi.",
                            "Bilgi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Hiç kayıt yoksa yeni cihaz oluştur
                        int newDeviceId = repository.AddDevice(device);

                        DeviceMovement movement = new DeviceMovement();

                        movement.DeviceId = newDeviceId;

                        movement.MovementType = "Oluşturuldu";

                        movement.FromEmployeeId = null;
                        movement.ToEmployeeId = device.EmployeeId;

                        movement.FromFacilityId = null;
                        movement.ToFacilityId = device.FacilityId;

                        movement.FromStatusId = null;
                        movement.ToStatusId = device.StatusId;

                        movement.Description = "Cihaz sisteme ilk kez eklendi.";

                        movement.MovementDate = DateTime.Now;

                        DeviceMovementRepository movementRepository =
                            new DeviceMovementRepository();

                        movementRepository.AddMovement(movement);

                        MessageBox.Show(
                            "Cihaz başarıyla eklendi.",
                            "Bilgi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Hata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private string GetStatusMovementType(int oldStatusId, int newStatusId)
        {
            if (newStatusId == 4)
            {
                return "Garantiye Gönderildi";
            }

            if (oldStatusId == 4)
            {
                return "Garantiden Geldi";
            }

            if (newStatusId == 2)
            {
                return "Hurdaya Ayrıldı";
            }

            return "Durum Değiştirildi";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
