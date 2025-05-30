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
    
    public partial class ScheduleMaintenancePanel : Form
    {
        public string SelectedVehicle = String.Empty;
        private DateTimePicker dtpTime; // Added declaration for dtpTime  

        public ScheduleMaintenancePanel()
        {
            InitializeComponent();
            InitializeCustomComponents(); // Added method call to initialize dtpTime  
            
        }

        private void InitializeCustomComponents()
        {
            // Initialize dtpTime  
            
            dtpTime = new DateTimePicker
            {
                Format = DateTimePickerFormat.Time,
                ShowUpDown = true,
                Location = new Point(150, 100), // Adjust location as needed  
                Size = new Size(100, 20) // Adjust size as needed  
            };
            Controls.Add(dtpTime);
        }



        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedVehicle))
            {
                MessageBox.Show("Please pick a vehicle");
                return;
            }
            string maintenanceType = cmbMaintenanceType.SelectedItem?.ToString();
            string description = txtDescription.Text.Trim();

            // Combine date and time  
            DateTime scheduledDate = dtpDate.Value.Date;
            TimeSpan scheduledTime = dtpTime.Value.TimeOfDay;
            DateTime scheduledDateTime = scheduledDate.Add(scheduledTime);

            // Save to database  

            try
            {
                var maintenance = new Maintenance
                {
                    UserId = SessionManager.GetCurrentUserId(),
                    MaintenanceType = maintenanceType,
                    VehicleId = int.Parse(SelectedVehicle),
                    Description = description,
                    ScheduledDateTime = scheduledDateTime
                };
                var maintenanceRepo = new MaintenanceRepo();
                maintenanceRepo.AddScheduledMaintenance(maintenance);

                MessageBox.Show("Maintenance scheduled successfully!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid vehicle selection. Please pick a valid vehicle.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while scheduling maintenance:\n" + ex.Message);
            }
        }

        private void btnPickVehicle_Click(object sender, EventArgs e)
        {
            SelectVehicleForm selectVehicle = new SelectVehicleForm();
            selectVehicle.ShowDialog();
        }
    }
}
