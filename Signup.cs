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


namespace VehicleMaintenanceSystem
{

    public partial class Signup : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Louie\source\repos\wilu-git\VehicleMaintenanceSystem\UserDatabase.mdf;Integrated Security=True;";
        
        public Signup()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            txtFirstName.KeyPress += NameTextBox_KeyPress;
            txtLastName.KeyPress += NameTextBox_KeyPress;
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
            // MODULARIZE IN NEXT (AFTER DASHBOARD)
            /* 
             Phone number is 11 digits, starts with 09 and all integer
             Password is the same with Confirm Password 
             Username is not yet taken 

             Optional: Add address ;_;
             */

            //Fields are empty
            if (IsAnyTextBoxEmpty())
            {
                MessageBox.Show("All fields must be filled");
                return;
            }

            //Phone number validator
            if (!IsPhoneNumberValid(txtPhoneNumber.Text.Trim())) //trims whitespace
                return;

            //Password Checker
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                MessageBox.Show("Password does not match");
                txtConfirmPassword.Clear();
                txtPassword.Clear();
                return;
            }

            //Add to database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                using (SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    int userCount = (int)checkCmd.ExecuteScalar();
                    if (userCount > 0)
                    {
                        MessageBox.Show("Username is already taken.");
                        return;
                    }
                }
                string newUserQuery = "INSERT INTO Users (FirstName, LastName, PhoneNumber, Username, Password) VALUES (@firstName, @lastName, @phone, @username, @password)";
                SqlCommand cmd = new SqlCommand(newUserQuery, conn);
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sign-up successful!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool IsPhoneNumberValid(string phone){
            //checks if the phone number is longer or shorter than 11 digits
            if (phone.Length != 11)
            {
                MessageBox.Show("Phone number must be 11 digits");
                txtPhoneNumber.Clear();
                return false;

            }

            //checks if the phone number starts with 
            else if (!phone.StartsWith("09") || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone Number invalid");
                txtPhoneNumber.Clear();
                return false;
            }

            else
            {
                return true;
            }
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
