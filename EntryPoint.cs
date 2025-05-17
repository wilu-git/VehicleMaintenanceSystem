using System.Data.SqlClient;

namespace VehicleMaintenanceSystem
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Louie\source\repos\wilu-git\VehicleMaintenanceSystem\UserDatabase.mdf;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }
        

        private void labelSignup_Click(object sender, EventArgs e)
        {
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
