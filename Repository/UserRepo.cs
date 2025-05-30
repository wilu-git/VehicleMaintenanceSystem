using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using VehicleMaintenanceSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Xml;

namespace VehicleMaintenanceSystem.Repository
{
    internal class UserRepo
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Louie\source\Files\VehicleMaintenanceSystem\VMSdb.mdf;Integrated Security=True";
        

        public bool IsUsernameTaken (string username)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open ();
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;
          
        }
        public string GetUserRole(string username, string password)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            var role = cmd.ExecuteScalar() as string;
            conn.Close();
            return role; // returns null if not found
        }
        public bool IsCredentialValid(string enteredUser, string enteredPassword)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", enteredUser);
            cmd.Parameters.AddWithValue("@password", enteredPassword);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count > 0;

        }
                        
        public bool RegisterUser(Users user)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            

            string query = "INSERT INTO Users (FirstName, LastName, Username, Password, PhoneNumber) VALUES (@firstname, @lastname, @username, @password, @phonenumber)";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@firstname", user.FirstName);
            cmd.Parameters.AddWithValue("@lastname", user.LastName);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@phonenumber", user.PhoneNumber);
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            return rows > 0;
            
        }

        public List<Users> GetUsers(string keyword = null)
        {
            var users = new List<Users>();
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string query;
            SqlCommand cmd;

            if (string.IsNullOrWhiteSpace(keyword))
            {
                query = "SELECT Id, FirstName, LastName, Username, Password, PhoneNumber, Role FROM Users WHERE Role <> 'admin'";
                cmd = new SqlCommand(query, conn);
            }
            else
            {
                query = @"SELECT Id, FirstName, LastName, Username, Password, PhoneNumber, Role
                  FROM Users
                  WHERE (Username LIKE @kw OR FirstName LIKE @kw OR LastName LIKE @kw) AND Role <> 'admin'";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
            }

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new Users
                {
                    Id = reader["Id"].ToString(),
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    Username = reader["Username"].ToString(),
                    Password = reader["Password"].ToString(),
                    PhoneNumber = reader["PhoneNumber"].ToString(),
                });
            }
            conn.Close();
            return users;
        }

        public bool UpdateUser(Users user)
        {
            using var conn = new SqlConnection(connectionString);
            
                conn.Open();
                string query = @"UPDATE Users SET 
                            FirstName = @FirstName,
                            LastName = @LastName,
                            Username = @Username,
                            Password = @Password,
                            PhoneNumber = @PhoneNumber
                         WHERE Id = @Id";

                using var cmd = new SqlCommand(query, conn);
                
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Id", user.Id);

                    return cmd.ExecuteNonQuery() > 0;            
        }

        public void DeleteUser(string Id)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "DELETE FROM Users WHERE ID = @id";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

    }
}
