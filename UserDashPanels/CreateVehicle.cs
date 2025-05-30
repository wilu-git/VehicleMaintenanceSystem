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

namespace VehicleMaintenanceSystem.UserDashPanels
{

    public partial class CreateVehicle : Form
    {
        private readonly Dictionary<string, List<string>> makeModelDict = new()
{
    { "Toyota", new() { "Hilux", "HiAce", "Innova", "Vios", "Fortuner" } },
    { "Mitsubishi", new() { "L300", "Montero", "Strada", "Mirage" } },
    { "Honda", new() { "Civic", "City", "CR-V", "Jazz" } },
    { "Isuzu", new() { "MU-X", "D-Max", "Crosswind" } },
    { "Ford", new() { "Ranger", "Everest", "EcoSport" } },
    { "Hyundai", new() { "Accent", "Tucson", "Starex" } },
    { "Nissan", new() { "Navara", "Terra", "Almera" } }
};

        private readonly List<string> validColors = new() { "White", "Black", "Gray", "Silver", "Red", "Blue", "Green", "Yellow" };
        private readonly List<string> validFuelTypes = new() { "Diesel", "Gasoline", "Electric", "Hybrid" };
        private readonly List<string> validWheelDriveTypes = new() { "4x2", "4x4", "AWD", "FWD", "RWD" };
        private readonly List<string> validTransmissionTypes = new() { "Automatic", "Manual", "CVT" };
        private readonly List<string> validVehicleTypes = new() { "Sedan", "SUV", "Van", "Pickup", "Motorcycle", "Jeep", "Truck" };
        private readonly List<string> validEngineConfigurations = new() { "V4", "V6", "V8", "Inline-4", "Inline-6", "Electric" };
        public CreateVehicle()
        {
            InitializeComponent();

            cmbMake.DataSource = makeModelDict.Keys.ToList();
            cmbColor.DataSource = validColors;
            cmbFuelType.DataSource = validFuelTypes;
            cmbWheelDriveType.DataSource = validWheelDriveTypes;
            cmbTransmissionType.DataSource = validTransmissionTypes;
            cmbVehicleType.DataSource = validVehicleTypes;
            cmbEngineConfiguration.DataSource = validEngineConfigurations;

            cmbMake.SelectedIndexChanged += cmbMake_SelectedIndexChanged;
        }

        private void cmbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMake = cmbMake.SelectedItem?.ToString();
            if (selectedMake != null && makeModelDict.ContainsKey(selectedMake))
                cmbModel.DataSource = makeModelDict[selectedMake];
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // VIN validation
            var vin = txtVIN.Text.Trim().ToUpper();
            if (vin.Length != 17)
            {
                MessageBox.Show("VIN must be exactly 17 characters long.");
                return;
            }
            for (int i = 0; i < vin.Length; i++)
            {
                char c = vin[i];
                // Check for invalid characters: I, O, Q
                if (c == 'I' || c == 'O' || c == 'Q')
                {
                    MessageBox.Show("VIN must not contain the letters I, O, or Q.");
                    return;
                }
                // Check for allowed characters: A-H, J-N, P, R-Z, 0-9
                if (!(char.IsDigit(c) || (c >= 'A' && c <= 'Z')))
                {
                    MessageBox.Show("VIN must contain only alphanumeric characters (A-H, J-N, P, R-Z, 0-9).");
                    return;
                }
            }

            // Year validation
            if (!int.TryParse(txtYear.Text, out int year) || year < 1990 || year > DateTime.Now.Year)
            {
                MessageBox.Show($"Year must be between 1990 and {DateTime.Now.Year}.");
                return;
            }

            // Registration number validation
            var regNum = txtRegistrationNumber.Text.Trim().ToUpper();

            bool valid = false;
            if (regNum.Length == 6 || regNum.Length == 7)
            {
                // Format: ABC123 or ABC1234
                if (regNum.Length == 6 || regNum.Length == 7)
                {
                    bool letters = true;
                    for (int i = 0; i < 3; i++)
                    {
                        if (regNum[i] < 'A' || regNum[i] > 'Z')
                        {
                            letters = false;
                            break;
                        }
                    }
                    bool digits = true;
                    for (int i = 3; i < regNum.Length; i++)
                    {
                        if (regNum[i] < '0' || regNum[i] > '9')
                        {
                            digits = false;
                            break;
                        }
                    }
                    if (letters && digits)
                        valid = true;
                }
            }
            else if (regNum.Length == 7 || regNum.Length == 8)
            {
                // Format: ABC 123 or ABC 1234
                if (regNum[3] == ' ' || regNum[3] == '-')
                {
                    bool letters = true;
                    for (int i = 0; i < 3; i++)
                    {
                        if (regNum[i] < 'A' || regNum[i] > 'Z')
                        {
                            letters = false;
                            break;
                        }
                    }
                    bool digits = true;
                    for (int i = 4; i < regNum.Length; i++)
                    {
                        if (regNum[i] < '0' || regNum[i] > '9')
                        {
                            digits = false;
                            break;
                        }
                    }
                    if (letters && digits)
                        valid = true;
                }
            }

            if (!valid)
            {
                MessageBox.Show("Registration number must match Philippine LTO plate format (e.g., ABC 1234 or ABC123).");
                return;
            }

            // Mileage validation
            if (!int.TryParse(txtMileage.Text, out int mileage) || mileage < 0 || mileage > 500_000)
            {
                MessageBox.Show("Mileage must be between 0 and 500,000 km.");
                return;
            }

            int userId = VehicleMaintenanceSystem.Models.SessionManager.CurrentUserId;


            // Ensure all dropdowns have selected values  
            if (IsAnyComboUnselected())
            {
                MessageBox.Show("Please ensure all dropdowns have selected values.");
                return;
            }

            // Create and save the vehicle
            var vehicle = new Vehicles
            {
                VIN = vin,
                Make = cmbMake.SelectedItem.ToString(),
                Model = cmbModel.SelectedItem.ToString(),
                Year = year,
                Color = cmbColor.SelectedItem.ToString(),
                FuelType = cmbFuelType.SelectedItem.ToString(),
                WheelDriveType = cmbWheelDriveType.SelectedItem.ToString(),
                TransmissionType = cmbTransmissionType.SelectedItem.ToString(),
                VehicleType = cmbVehicleType.SelectedItem.ToString(),
                EngineConfiguration = cmbEngineConfiguration.SelectedItem.ToString(),
                RegistrationNumber = regNum,
                Mileage = mileage,
                UserID = userId,
            };

            var vehicleRepo = new VehicleRepo();
            vehicleRepo.AddVehicleForCurrentUser(vehicle);
            MessageBox.Show("Vehicle added successfully.");
            this.Close();
        }

        private bool IsAnyComboUnselected()
        {
            return
            cmbMake.SelectedItem == null ||
            cmbModel.SelectedItem == null ||
            cmbColor.SelectedItem == null ||
                cmbFuelType.SelectedItem == null ||
                cmbWheelDriveType.SelectedItem == null ||
                cmbTransmissionType.SelectedItem == null ||
                cmbVehicleType.SelectedItem == null ||
                cmbEngineConfiguration.SelectedItem == null;
        }
    }
}
