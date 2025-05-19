using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VehicleMaintenanceSystem
{
    public partial class EntryPoint : Form
    {
        private string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Louie\source\Files\VehicleMaintenanceSystem\Databases\UserAdminDb.mdf;Integrated Security = True";

        public EntryPoint()
        {
            InitializeComponent();
        }
        

        private void labelSignup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using var conn = new SqlConnection(connectionString); 
            conn.Open();
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
            using var cmd = new SqlCommand(query, conn); 

            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }
    }
}
