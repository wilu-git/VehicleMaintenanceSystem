using Microsoft.VisualBasic.Devices;
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
using VehicleMaintenanceSystem.Models;
using VehicleMaintenanceSystem.Repository;

namespace VehicleMaintenanceSystem
{
    public partial class UsersEditorPanel : Form
    {
        private BindingSource usersBindingSource = new();
        private UserRepo userRepo = new();

        public UsersEditorPanel()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            LoadUsers();
        }
       

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridUsers.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridUsers.SelectedRows[0];
                var user = (Users)selectedRow.DataBoundItem;
                var confirm = MessageBox.Show("Delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    userRepo.DeleteUser(user.Id);
                    MessageBox.Show("User Deleted");
                    LoadUsers();
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridUsers.SelectedRows.Count > 0) 
            {
                // Get the selected user data from the DataGridView  
                var selectedRow = dataGridUsers.SelectedRows[0]; 

                // Safely handle possible null values using null-coalescing operator  
                var user = new Users
                {
                    Id = selectedRow.Cells["Id"].Value?.ToString() ?? string.Empty,
                    FirstName = selectedRow.Cells["FirstName"].Value?.ToString() ?? string.Empty, 
                    LastName = selectedRow.Cells["LastName"].Value?.ToString() ?? string.Empty,
                    Username = selectedRow.Cells["Username"].Value?.ToString() ?? string.Empty,
                    Password = selectedRow.Cells["Password"].Value?.ToString() ?? string.Empty,
                    PhoneNumber = selectedRow.Cells["PhoneNumber"].Value?.ToString() ?? string.Empty
                };

                // Pass the user to the edit form  
                var editForm = new UserInformationEditForm(user);
                editForm.ShowDialog();
                LoadUsers();
                dataGridUsers.Refresh();
            }
        }

        private void LoadUsers()
        {
            var users = userRepo.GetUsers();
            usersBindingSource.DataSource = users;
            dataGridUsers.DataSource = usersBindingSource;
        }
    }
}
