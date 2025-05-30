using System;
using System.Data.SqlClient;
using VehicleMaintenanceSystem.Models;

namespace VehicleMaintenanceSystem.Repository
{
    public class MaintenanceRepo
    {
        private readonly string _connectionString = "YourConnectionStringHere";

        public void AddScheduledMaintenance(Maintenance maintenance)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"INSERT INTO Maintenance (UserId, VehicleId, MaintenanceType, Description, ScheduledDateTime)
                                 VALUES (@UserId, @VehicleId, @MaintenanceType, @Description, @ScheduledDateTime)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", maintenance.UserId);
                    command.Parameters.AddWithValue("@VehicleId", maintenance.VehicleId);
                    command.Parameters.AddWithValue("@MaintenanceType", maintenance.MaintenanceType);
                    command.Parameters.AddWithValue("@Description", maintenance.Description ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@ScheduledDateTime", maintenance.ScheduledDateTime);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

