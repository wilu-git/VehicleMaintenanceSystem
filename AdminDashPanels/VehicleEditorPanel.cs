using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleMaintenanceSystem.Models;
using VehicleMaintenanceSystem.Repository;

namespace VehicleMaintenanceSystem.Database_Editors
{
    public partial class VehicleEditorPanel : Form
    {
        private BindingSource vehiclesBindingSource = new();
        private VehicleRepo vehicleRepo = new();
        public VehicleEditorPanel()
        {
            InitializeComponent();
            LoadVehicles();
        }

        private void btnSearchByUser_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var vehicles = vehicleRepo.GetAllVehiclesWithUser()
                .Where(v => v.UserFullName.ToLower().Contains(keyword) || v.UserID.ToString() == keyword)
                .ToList();
            vehiclesBindingSource.DataSource = vehicles;
            dataGridVehicles.DataSource = vehiclesBindingSource;
        }

        private void btnSearchbyVehicleName_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var vehicles = vehicleRepo.GetAllVehiclesWithUser()
                .Where(v => v.Make.ToLower().Contains(keyword) || v.Model.ToLower().Contains(keyword))
                .ToList();
            vehiclesBindingSource.DataSource = vehicles;
            dataGridVehicles.DataSource = vehiclesBindingSource;
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            //var addForm = new VehicleInformationEdit();
            //addForm.ShowDialog();
            //LoadVehicles();
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            if (dataGridVehicles.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridVehicles.SelectedRows[0];
                var vehicle = (Vehicles)selectedRow.DataBoundItem;
                var editForm = new VehicleInformationEditForm(vehicle);
                editForm.ShowDialog();
                dataGridVehicles.Refresh();
            }
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (dataGridVehicles.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridVehicles.SelectedRows[0];
                var vehicle = (Vehicles)selectedRow.DataBoundItem;
                var confirm = MessageBox.Show("Delete this vehicle?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    vehicleRepo.DeleteVehicle(vehicle.VehicleID);
                    MessageBox.Show("Vehicle Deleted");
                    LoadVehicles();
                }
            }
        }
        private void LoadVehicles()
        {
            var vehicles = vehicleRepo.GetAllVehiclesWithUser();
            vehiclesBindingSource.DataSource = vehicles;
            dataGridVehicles.DataSource = vehiclesBindingSource;
        }
    }
}
