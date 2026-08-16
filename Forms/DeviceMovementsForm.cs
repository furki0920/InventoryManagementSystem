using InventoryManagementSystem.DAL;
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
    public partial class DeviceMovementsForm : Form
    {
        public DeviceMovementsForm()
        {
            InitializeComponent();
        }

        private void DeviceMovementsForm_Load(object sender, EventArgs e)
        {
            DeviceMovementRepository repository = new DeviceMovementRepository();

            dgv_DeviceMovements.DataSource = repository.GetAllMovements();

            dgv_DeviceMovements.Columns["Id"].Visible = false;

            dgv_DeviceMovements.Columns["SerialNumber"].HeaderText = "Seri No";

            dgv_DeviceMovements.Columns["MovementType"].HeaderText = "Hareket";

            dgv_DeviceMovements.Columns["FromEmployee"].HeaderText = "Kimden";

            dgv_DeviceMovements.Columns["ToEmployee"].HeaderText = "Kime";

            dgv_DeviceMovements.Columns["MovementDate"].HeaderText = "Tarih";

            dgv_DeviceMovements.Columns["MovementDate"].DefaultCellStyle.Format =
    "dd.MM.yyyy HH:mm";

            dgv_DeviceMovements.Columns["Description"].HeaderText = "Açıklama";

            dgv_DeviceMovements.Columns["FromFacility"].HeaderText = "Eski Tesis";

            dgv_DeviceMovements.Columns["ToFacility"].HeaderText = "Yeni Tesis";

            dgv_DeviceMovements.Columns["FromStatus"].HeaderText = "Eski Durum";

            dgv_DeviceMovements.Columns["ToStatus"].HeaderText = "Yeni Durum";
        }

        private void SearchMovements()
        {
            DeviceMovementRepository repository = new DeviceMovementRepository();

            dgv_DeviceMovements.DataSource =
                repository.SearchMovements(txt_Search.Text.Trim());

            dgv_DeviceMovements.Columns["Id"].Visible = false;

            dgv_DeviceMovements.Columns["SerialNumber"].HeaderText = "Seri No";

            dgv_DeviceMovements.Columns["MovementType"].HeaderText = "Hareket";

            dgv_DeviceMovements.Columns["FromEmployee"].HeaderText = "Kimden";

            dgv_DeviceMovements.Columns["ToEmployee"].HeaderText = "Kime";

            dgv_DeviceMovements.Columns["FromFacility"].HeaderText = "Eski Tesis";

            dgv_DeviceMovements.Columns["ToFacility"].HeaderText = "Yeni Tesis";

            dgv_DeviceMovements.Columns["FromStatus"].HeaderText = "Eski Durum";

            dgv_DeviceMovements.Columns["ToStatus"].HeaderText = "Yeni Durum";

            dgv_DeviceMovements.Columns["MovementDate"].HeaderText = "Tarih";

            dgv_DeviceMovements.Columns["MovementDate"].DefaultCellStyle.Format =
    "dd.MM.yyyy HH:mm";

            dgv_DeviceMovements.Columns["Description"].HeaderText = "Açıklama";
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            SearchMovements();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
