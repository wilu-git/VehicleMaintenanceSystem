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

namespace VehicleMaintenanceSystem.UserDashPanels
{
    public partial class VehicleDetailsForm : Form
    {
        public VehicleDetailsForm(Vehicles vehicle)
        {
            InitializeComponent();
            txtVIN.Text = vehicle.VIN;
            txtMake.Text = vehicle.Make;
            txtModel.Text = vehicle.Model;
            txtYear.Text = vehicle.Year.ToString();
            txtColor.Text = vehicle.Color;
            txtFuelType.Text = vehicle.FuelType;
            txtWheelDriveType.Text = vehicle.WheelDriveType;
            txtTransmissionType.Text = vehicle.TransmissionType;
            txtVehicleType.Text = vehicle.VehicleType;
            txtEngineConfiguration.Text = vehicle.EngineConfiguration;
            txtRegistrationNumber.Text = vehicle.RegistrationNumber;
            txtMileage.Text = vehicle.Mileage.ToString();
            
        }
    }
}
