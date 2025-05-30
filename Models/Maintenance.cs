using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMaintenanceSystem.Models
{
    public class Maintenance
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VehicleId { get; set; }
        public string MaintenanceType { get; set; }
        public string Description { get; set; }
        public DateTime ScheduledDateTime { get; set; }
    }
}
