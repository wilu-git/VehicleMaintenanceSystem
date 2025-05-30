using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Repository
{
    public class VehicleRepo
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Louie\source\Files\VehicleMaintenanceSystem\VMSdb.mdf;Integrated Security=True";
        
        //used in 
        public List<Vehicles> GetVehiclesByUserId(int userId)
        {
            var vehicles = new List<Vehicles>();
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            string query = @"SELECT v.*, u.FirstName, u.LastName
                     FROM Vehicles v
                     LEFT JOIN Users u ON v.UserID = u.Id
                     WHERE v.UserID = @UserID";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", userId);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                vehicles.Add(new Vehicles
                {
                    VehicleID = Convert.ToInt32(reader["VehicleID"]),
                    VIN = reader["VIN"].ToString(),
                    Make = reader["Make"].ToString(),
                    Model = reader["Model"].ToString(),
                    Year = Convert.ToInt32(reader["Year"]),
                    Color = reader["Color"].ToString(),
                    FuelType = reader["FuelType"].ToString(),
                    WheelDriveType = reader["WheelDriveType"].ToString(),
                    TransmissionType = reader["TransmissionType"].ToString(),
                    VehicleType = reader["VehicleType"].ToString(),
                    EngineConfiguration = reader["EngineConfiguration"].ToString(),
                    RegistrationNumber = reader["RegistrationNumber"].ToString(),
                    Mileage = Convert.ToInt32(reader["Mileage"]),
                    UserID = Convert.ToInt32(reader["UserID"]),
                    UserFullName = $"{reader["FirstName"]} {reader["LastName"]}"
                });
            }
            return vehicles;
        }
        //userd in the vehicle edit in admin
        public List<Vehicles> GetAllVehiclesWithUser()
        {
            var vehicles = new List<Vehicles>();
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            string query = @"SELECT v.*, u.FirstName, u.LastName
                             FROM Vehicles v
                             LEFT JOIN Users u ON v.UserID = u.Id";
            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                vehicles.Add(new Vehicles
                {
                    VehicleID = Convert.ToInt32(reader["VehicleID"]),
                    VIN = reader["VIN"].ToString(),
                    Make = reader["Make"].ToString(),
                    Model = reader["Model"].ToString(),
                    Year = Convert.ToInt32(reader["Year"]),
                    Color = reader["Color"].ToString(),
                    FuelType = reader["FuelType"].ToString(),
                    WheelDriveType = reader["WheelDriveType"].ToString(),
                    TransmissionType = reader["TransmissionType"].ToString(),
                    VehicleType = reader["VehicleType"].ToString(),
                    EngineConfiguration = reader["EngineConfiguration"].ToString(),
                    RegistrationNumber = reader["RegistrationNumber"].ToString(),
                    Mileage = Convert.ToInt32(reader["Mileage"]),
                    UserID = Convert.ToInt32(reader["UserID"]),
                    UserFullName = $"{reader["FirstName"]} {reader["LastName"]}"
                });
            }
            return vehicles;
        }
        public void AddVehicleForCurrentUser(Vehicles vehicle)
        {
            vehicle.UserID = SessionManager.CurrentUserId; // or your session logic
            AddVehicle(vehicle);
        }
        public void AddVehicle(Vehicles vehicle)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            string query = @"INSERT INTO Vehicles (VIN, Make, Model, Year, Color, FuelType, WheelDriveType, TransmissionType, VehicleType, EngineConfiguration, RegistrationNumber, Mileage, UserID)
                             VALUES (@VIN, @Make, @Model, @Year, @Color, @FuelType, @WheelDriveType, @TransmissionType, @VehicleType, @EngineConfiguration, @RegistrationNumber, @Mileage, @UserID)";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@VIN", vehicle.VIN);
            cmd.Parameters.AddWithValue("@Make", vehicle.Make);
            cmd.Parameters.AddWithValue("@Model", vehicle.Model);
            cmd.Parameters.AddWithValue("@Year", vehicle.Year);
            cmd.Parameters.AddWithValue("@Color", vehicle.Color);
            cmd.Parameters.AddWithValue("@FuelType", vehicle.FuelType);
            cmd.Parameters.AddWithValue("@WheelDriveType", vehicle.WheelDriveType);
            cmd.Parameters.AddWithValue("@TransmissionType", vehicle.TransmissionType);
            cmd.Parameters.AddWithValue("@VehicleType", vehicle.VehicleType);
            cmd.Parameters.AddWithValue("@EngineConfiguration", vehicle.EngineConfiguration);
            cmd.Parameters.AddWithValue("@RegistrationNumber", vehicle.RegistrationNumber);
            cmd.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
            cmd.Parameters.AddWithValue("@UserID", vehicle.UserID);
            cmd.ExecuteNonQuery();
        }

        public void UpdateVehicle(Vehicles vehicle)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            string query = @"UPDATE Vehicles SET VIN=@VIN, Make=@Make, Model=@Model, Year=@Year, Color=@Color, FuelType=@FuelType, WheelDriveType=@WheelDriveType, TransmissionType=@TransmissionType, VehicleType=@VehicleType, EngineConfiguration=@EngineConfiguration, RegistrationNumber=@RegistrationNumber, Mileage=@Mileage, UserID=@UserID
                             WHERE VehicleID=@VehicleID";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@VIN", vehicle.VIN);
            cmd.Parameters.AddWithValue("@Make", vehicle.Make);
            cmd.Parameters.AddWithValue("@Model", vehicle.Model);
            cmd.Parameters.AddWithValue("@Year", vehicle.Year);
            cmd.Parameters.AddWithValue("@Color", vehicle.Color);
            cmd.Parameters.AddWithValue("@FuelType", vehicle.FuelType);
            cmd.Parameters.AddWithValue("@WheelDriveType", vehicle.WheelDriveType);
            cmd.Parameters.AddWithValue("@TransmissionType", vehicle.TransmissionType);
            cmd.Parameters.AddWithValue("@VehicleType", vehicle.VehicleType);
            cmd.Parameters.AddWithValue("@EngineConfiguration", vehicle.EngineConfiguration);
            cmd.Parameters.AddWithValue("@RegistrationNumber", vehicle.RegistrationNumber);
            cmd.Parameters.AddWithValue("@Mileage", vehicle.Mileage);
            cmd.Parameters.AddWithValue("@UserID", vehicle.UserID);
            cmd.Parameters.AddWithValue("@VehicleID", vehicle.VehicleID);
            cmd.ExecuteNonQuery();
        }

        public void DeleteVehicle(int vehicleId)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            string query = @"DELETE FROM Vehicles WHERE VehicleID=@VehicleID";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@VehicleID", vehicleId);
            cmd.ExecuteNonQuery();
        }
    }
}