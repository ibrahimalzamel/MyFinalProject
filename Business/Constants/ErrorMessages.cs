using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
     public static class ErrorMessages
    {
        private static string maintenanceTime = "Sistem bakımda";
        private static string productNameInvalid = "Ürün ismi geçersiz";
        private static string productNotDeleted = "HATA. Ürün Silinemedi";
        private static string customerNotAdded = "HATA. Müşteri Eklenemedi";
        private static string customerNotDeleted = "HATA. Müşteri Silinemedi";
        public static string MaintenanceTime1 { get => maintenanceTime; set => maintenanceTime = value; }
        public static string ProductNameInvalid { get => productNameInvalid; set => productNameInvalid = value; }
        public static string ProductNotDeleted { get => productNotDeleted; set => productNotDeleted = value; }
        public static string CustomerNotAdded { get => customerNotAdded; set => customerNotAdded = value; }
        public static string CustomerNotDeleted { get => customerNotDeleted; set => customerNotDeleted = value; }
    }
}
