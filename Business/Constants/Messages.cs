using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        private static string AuthorizationDenied = "Yetkiniz Yok.";
        private static string productAdded = "Ürün Eklendi";
        private static string productNameInvalid = "Ürün ismi geçersiz";
        private static string maintenanceTime = "Sistem bakımda";
        private static string productListed = "Ürünler Listelendi";

        public static string ProductAdded { get => productAdded; set => productAdded = value; }
        public static string ProductNameInvalid { get => productNameInvalid; set => productNameInvalid = value; }
        public static string MaintenanceTime { get => maintenanceTime; set => maintenanceTime = value; }
        public static string ProductListed { get => productListed; set => productListed = value; }
        public static string AuthorizationDenied1 { get => AuthorizationDenied; set => AuthorizationDenied = value; }
    }
}
