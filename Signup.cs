using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using VehicleMaintenanceSystem.Models;
using VehicleMaintenanceSystem.Repository;



namespace VehicleMaintenanceSystem
{

    public partial class Signup : Form
    {
        private UserRepo userRepo; // Add an instance of UserRepo

        public Signup()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            txtFirstName.KeyPress += NameTextBox_KeyPress;
            txtLastName.KeyPress += NameTextBox_KeyPress;

            userRepo = new UserRepo(); // Initialize the UserRepo instance
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Fields are empty
            if (IsAnyTextBoxEmpty())
            {
                MessageBox.Show("Phone number must be 11 digits");
                txtPhoneNumber.Clear();
                return;
            }

            // Phone number validator
            string phone = txtPhoneNumber.Text.Trim(); // trims whitespace
            if (!IsPhoneNumberValid(phone))
            {
                MessageBox.Show("Phone number invalid");
                txtPhoneNumber.Clear();
                return;
            }

            // Password Checker
            bool passwordMatch = (txtConfirmPassword.Text == txtPassword.Text);

            if (!passwordMatch)
            {
                MessageBox.Show("Password does not match");
                txtConfirmPassword.Clear();
                txtPassword.Clear();
                return;
            }

            // Check if username is taken
            string enteredUsername = txtUsername.Text.Trim();
            if (userRepo.IsUsernameTaken(enteredUsername)) 
            {
                MessageBox.Show("Username is already taken.");
                return;
            }

            // UserRepository class
            Users newUser = new Users
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                PhoneNumber = txtPhoneNumber.Text
            };

            bool success = userRepo.RegisterUser(newUser);
            string message = success ? "Sign-up successful" : "Sign-up failed";
            MessageBox.Show(message);

        }

        private static void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool IsPhoneNumberValid(string phone)
        {
            // checks if the phone number is longer or shorter than 11 digits
            if (phone.Length != 11 || !phone.StartsWith("09") || !phone.All(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        private bool IsAnyTextBoxEmpty()
        {
            return
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text);
        }
    }
}
