using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMaintenanceSystem.Models
{
    public class Vehicles
    {
        
        public int VehicleID { get; set; } //Unique ID for database
        public string VIN { get; set; } // Unique Vehicle identification Number (helps to identify the specific vehicle)
        public string Make { get; set; } // Toyota, Hyundai, Mitsubishi
        public string Model { get; set; } //What model, Hilux, HiAce, Innova, MU-X
        public int Year { get; set; } // Year model
        public string Color { get; set; } //body color 
        public string FuelType { get; set; } //Diesel, premium, regular octane levels
        public string WheelDriveType { get; set; } //4 x 2, how many wheels and how many wheel does engine carry
        public string TransmissionType { get; set; } //Automatic, 
        public string VehicleType { get; set; } // Van, car, jeep, motor, pick-up trucks, SUVs
        public string EngineConfiguration { get; set; } //V
        public string RegistrationNumber { get; set; } // Number that is unique from the LTO office
        public int Mileage { get; set; } //how much mileage the car has (unit in km)
        public int UserID { get; set; } //Foreign Key to input the user's ID
        public string UserFullName { get; set; } // Not mapped to DB, for display only
    }
}
