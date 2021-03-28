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
        private static string ProductCountOfCategoreError = "Bir kategori en fazla 10 Ürün Olabilir";
        private static string ProductNameAlreadyExists = "Bu ismide Zaten başka bir Ürün var";
        private static string categoryLimitExceded = "catrgory limiti aşıldığı için yeni ürün eklenemiyor";
        public static string MaintenanceTime1 { get => maintenanceTime; set => maintenanceTime = value; }
        public static string ProductNameInvalid { get => productNameInvalid; set => productNameInvalid = value; }
        public static string ProductNotDeleted { get => productNotDeleted; set => productNotDeleted = value; }
        public static string CustomerNotAdded { get => customerNotAdded; set => customerNotAdded = value; }
        public static string CustomerNotDeleted { get => customerNotDeleted; set => customerNotDeleted = value; }
        public static string ProductCountOfCategoreError1 { get => ProductCountOfCategoreError; set => ProductCountOfCategoreError = value; }
        public static string ProductNameAlreadyExists1 { get => ProductNameAlreadyExists; set => ProductNameAlreadyExists = value; }
        public static string CategoryLimitExceded { get => categoryLimitExceded; set => categoryLimitExceded = value; }
    }
}
