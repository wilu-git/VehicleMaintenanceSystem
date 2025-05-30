using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleMaintenanceSystem;
using VehicleMaintenanceSystem.Models;
using VehicleMaintenanceSystem.Repository;


namespace VehicleMaintenanceSystem.Database_Editors
{
    public partial class UserInformationEditForm : Form
    {
        private Users user;
        private UserRepo userRepo;
        public UserInformationEditForm(Users user)
        {
            InitializeComponent();
            this.user = user;
            userRepo = new UserRepo();

            txtID.Text = user.Id;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtUsername.Text = user.Username;
            txtPassword.Text = user.Password;
            txtPhoneNumber.Text = user.PhoneNumber;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to save the changes?",
                "Confirm Save",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Update user with edited values
                user.FirstName = txtFirstName.Text.Trim();
                user.LastName = txtLastName.Text.Trim();
                user.Username = txtUsername.Text.Trim();
                user.Password = txtPassword.Text;
                user.PhoneNumber = txtPhoneNumber.Text.Trim();

                // Save to database
                bool success = userRepo.UpdateUser(user);
                MessageBox.Show(success ? "User updated successfully." : "Update failed.");
                if (success) this.Close();
                else return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
