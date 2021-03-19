using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
     public static class ErrorMessages
    {
        private static string maintenanceTime = "Sistem bakımda";

        public static string MaintenanceTime { get => maintenanceTime; set => maintenanceTime = value; }
    }
}
