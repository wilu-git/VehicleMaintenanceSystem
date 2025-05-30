using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VehicleMaintenanceSystem.Models;
using VehicleMaintenanceSystem.Repository;

namespace VehicleMaintenanceSystem.UserDashPanels
{
    public partial class ViewVehiclePanel : Form
    {
        public ViewVehiclePanel()
        {
            InitializeComponent();
            LoadUserVehicles();
            dataGridViewVehicles.CellDoubleClick += dataGridViewVehicles_CellDoubleClick;
        }

        private void LoadUserVehicles()
        {
            int userId = SessionManager.CurrentUserId;
            var repo = new VehicleRepo();
            var vehicles = repo.GetVehiclesByUserId(userId);

            // Show only limited columns
            dataGridViewVehicles.DataSource = vehicles.Select(v => new
            {
                v.VehicleID,
                v.Model,
                v.Make,
                v.Year,
                v.Color,
                v.VehicleType
            }).ToList();
        }

        private void dataGridViewVehicles_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVehicles.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridViewVehicles.SelectedRows[0].Cells["VehicleID"].Value;
                dataGridViewVehicles.Columns[0].Visible = false;
                // Find the full vehicle object if you want to show more details
                // Show details in a dialog or another panel
            }
        }
        private void dataGridViewVehicles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the VehicleID from the hidden column
                int vehicleId = (int)dataGridViewVehicles.Rows[e.RowIndex].Cells["VehicleID"].Value;

                // Fetch the full vehicle details
                var repo = new VehicleRepo();
                var vehicle = repo.GetVehiclesByUserId(SessionManager.CurrentUserId)
                                  .FirstOrDefault(v => v.VehicleID == vehicleId);

                if (vehicle != null)
                {
                    // Show details in a dialog (implement this form as needed)
                    var detailsForm = new VehicleDetailsForm(vehicle);
                    detailsForm.ShowDialog();
                }
            }
        }

        private void dataGridViewVehicles_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}