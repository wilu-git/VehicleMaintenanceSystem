using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VehicleMaintenanceSystem.Models;
using VehicleMaintenanceSystem.Repository;

namespace VehicleMaintenanceSystem.UserDashPanels
{
    public partial class SelectVehicleForm : Form
    {
        public Vehicles SelectedVehicle { get; private set; }

        public SelectVehicleForm()
        {
            InitializeComponent();
            LoadVehicles();
        }

        private void LoadVehicles()
        {
            int currentUser = SessionManager.GetCurrentUserId();
            var repo = new VehicleRepo();
            var vehicles = repo.GetVehiclesByUserId(currentUser); 

            dgvVehicles.DataSource = vehicles;
            dgvVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicles.ReadOnly = true;
            dgvVehicles.AutoGenerateColumns = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count > 0)
            {
                SelectedVehicle = dgvVehicles.SelectedRows[0].DataBoundItem as Vehicles;
                if (SelectedVehicle != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a vehicle.");
            }
        }
    }
}