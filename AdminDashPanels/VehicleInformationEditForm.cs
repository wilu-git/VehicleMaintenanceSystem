using System;
using System.Windows.Forms;
using VehicleMaintenanceSystem.Models;
using VehicleMaintenanceSystem.Repository;

namespace VehicleMaintenanceSystem.Database_Editors
{
    public partial class VehicleInformationEditForm : Form
    {
        private Vehicles vehicle;
        private VehicleRepo vehicleRepo;

        public VehicleInformationEditForm(Vehicles vehicle)
        {
            InitializeComponent();
            this.vehicle = vehicle;
            vehicleRepo = new VehicleRepo();

            // Populate fields with vehicle data
            txtVehicleID.Text = vehicle.VehicleID.ToString();
            txtVIN.Text = vehicle.VIN;
            txtMake.Text = vehicle.Make;
            txtModel.Text = vehicle.Model;
            txtYear.Text = vehicle.Year.ToString();
            txtColor.Text = vehicle.Color;
            txtFuelType.Text = vehicle.FuelType;
            txtWheelDriveType.Text = vehicle.WheelDriveType;
            txtVehicleType.Text = vehicle.TransmissionType;
            txtTransmissionType.Text = vehicle.VehicleType;
            txtEngineConfiguration.Text = vehicle.EngineConfiguration;
            txtRegistrationNumber.Text = vehicle.RegistrationNumber;
            txtMileage.Text = vehicle.Mileage.ToString();
            txtUserID.Text = vehicle.UserID.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsAnyTextBoxEmpty())
            {
                MessageBox.Show("Fields cannot be empty");
                return;
            }
            var result = MessageBox.Show(
                "Are you sure you want to save the changes?",
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Update vehicle with edited values
                vehicle.VIN = txtVIN.Text.Trim();
                vehicle.Make = txtMake.Text.Trim();
                vehicle.Model = txtModel.Text.Trim();
                vehicle.Year = int.TryParse(txtYear.Text, out int year) ? year : vehicle.Year;
                vehicle.Color = txtColor.Text.Trim();
                vehicle.FuelType = txtFuelType.Text.Trim();
                vehicle.WheelDriveType = txtWheelDriveType.Text.Trim();
                vehicle.TransmissionType = txtVehicleType.Text.Trim();
                vehicle.VehicleType = txtVehicleType.Text.Trim();
                vehicle.EngineConfiguration = txtEngineConfiguration.Text.Trim();
                vehicle.RegistrationNumber = txtRegistrationNumber.Text.Trim();
                vehicle.Mileage = int.TryParse(txtMileage.Text, out int mileage) ? mileage : vehicle.Mileage;
                vehicle.UserID = int.TryParse(txtUserID.Text, out int userId) ? userId : vehicle.UserID;

                // Save to database
                vehicleRepo.UpdateVehicle(vehicle);
                MessageBox.Show("Vehicle updated successfully.");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsAnyTextBoxEmpty()
        {
            // Exclude txtVehicleID if it's read-only or auto-generated
            return string.IsNullOrWhiteSpace(txtVIN.Text)
                || string.IsNullOrWhiteSpace(txtMake.Text)
                || string.IsNullOrWhiteSpace(txtModel.Text)
                || string.IsNullOrWhiteSpace(txtYear.Text)
                || string.IsNullOrWhiteSpace(txtColor.Text)
                || string.IsNullOrWhiteSpace(txtFuelType.Text)
                || string.IsNullOrWhiteSpace(txtWheelDriveType.Text)
                || string.IsNullOrWhiteSpace(txtTransmissionType.Text)
                || string.IsNullOrWhiteSpace(txtVehicleType.Text)
                || string.IsNullOrWhiteSpace(txtEngineConfiguration.Text)
                || string.IsNullOrWhiteSpace(txtRegistrationNumber.Text)
                || string.IsNullOrWhiteSpace(txtMileage.Text)
                || string.IsNullOrWhiteSpace(txtUserID.Text);
        }
    }
}