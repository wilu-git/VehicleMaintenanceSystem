using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleMaintenanceSystem.UserDashPanels;

namespace VehicleMaintenanceSystem
{
    public partial class UserDash : Form
    {
        public UserDash()
        {
            InitializeComponent();
        }

        private void btnViewVehicles_Click(object sender, EventArgs e)
        {
            var viewVehicle = new ViewVehiclePanel
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(viewVehicle);
            viewVehicle.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var createVehicle = new CreateVehicle
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(createVehicle);
            createVehicle.Show();
        }

        private void btnScheduleMaintenance_Click(object sender, EventArgs e)
        {
            var scheduleMaintenance = new ScheduleMaintenancePanel
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(scheduleMaintenance);
            scheduleMaintenance.Show();
        }
    }
}
