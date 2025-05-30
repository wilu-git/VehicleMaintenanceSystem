using System.Data.SqlClient;
using VehicleMaintenanceSystem.Models;
using VehicleMaintenanceSystem.Repository;

namespace VehicleMaintenanceSystem
{
    
    public partial class EntryPoint : Form
    {
        private UserRepo userRepo;
        

        public EntryPoint()
        {
            InitializeComponent();
            userRepo = new UserRepo();
            this.KeyPreview = true;
            this.KeyDown += EntryPoint_KeyDown;
        }
        //It is so that i can use enter to login instead of pressing the button
        private void EntryPoint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Control)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter && e.Control)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }
        private void labelSignup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.ShowDialog();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;
            string role = userRepo.GetUserRole(enteredUsername, enteredPassword);

            if (IsAnyTextBoxEmpty() )
            {
                MessageBox.Show("Fields must not be empty");
                return;
            }
            
            else if (role == null)
            {
                MessageBox.Show("Invalid Credentials");
                txtUsername.Clear();
                txtPassword.Clear();
                return;
            }

            else if (role == "admin")
            {
                txtUsername.Clear();
                txtPassword.Clear();
                AdminDash adminCRUD = new AdminDash();
                adminCRUD.ShowDialog();
            }
            else
            {
                var user = userRepo.GetUsers().FirstOrDefault(u => u.Username == enteredUsername && u.Password == enteredPassword);
                if (user != null && int.TryParse(user.Id, out int userId))
                {
                    SessionManager.CurrentUserId = userId;
                }
                txtUsername.Clear();
                txtPassword.Clear();
                UserDash userDash = new UserDash();
                userDash.ShowDialog();
            }

        }
        private bool IsAnyTextBoxEmpty()
        {
            return
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text);
                
        }

    }
}
