using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMaintenanceSystem.Models
{
    public static class SessionManager
    {
        public static int CurrentUserId { get; set; }
        public static int GetCurrentUserId()
        {
            return SessionManager.CurrentUserId;
        }
    }

}
