using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleMaintenanceSystem.Database_Editors;

namespace VehicleMaintenanceSystem
{
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();

        }

        private void btnUsersEditor_Click(object sender, EventArgs e)
        {
            var usersEditorPanel = new UsersEditorPanel
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(usersEditorPanel);
            usersEditorPanel.Show();
        }
        private void btnVehiclesEditor_Click(object sender, EventArgs e)
        {
            var vehicleEditorPanel = new VehicleEditorPanel
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(vehicleEditorPanel);
            vehicleEditorPanel.Show();
        }

        private void btnManageData_Click(object sender, EventArgs e)
        {

        }

        private void btnManageMaintenance_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}
