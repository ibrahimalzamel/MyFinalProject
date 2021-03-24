using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class SuccessMessages
    {
        private static string productAdded = "Ürün Eklendi";
        private static string productListed = "Ürünler Listelendi";
        private static string productUpdated = "Ürün Güncellendi";
        private static string productDeleted = "Ürün silindi";

        private static string categoryAdded = "Kategori Eklendi";
        private static string categoryUpdated = "Kategori Güncellendi";
        private static string categoryListed = "Kategoriler  Listeleniyor...";
        private static string categoryDeleted = "Kategori silindi"; 

        private static string orderAdded = "sipariş Eklendi";
        private static string orderUpdated = "sipariş Güncellendi";
        private static string orderListed = "siparişler Listeleniyor...";
        private static string orderDeleted = "sipariş silindi";

        private static string customerAdded = "Müşteri Eklendi";
        private static string customerUpdated = "Müşteri Güncellendi";
        private static string customerListed = "Müşteriler  Listeleniyor...";
        private static string customerDeleted = "Müşteri silindi";

        public static string ProductAdded { get => productAdded; set => productAdded = value; }
        public static string ProductListed { get => productListed; set => productListed = value; }
        public static string ProductUpdated { get => productUpdated; set => productUpdated = value; }
        public static string ProductDeleted { get => productDeleted; set => productDeleted = value; }
        public static string CategoryAdded { get => categoryAdded; set => categoryAdded = value; }
        public static string CategoryUpdated { get => categoryUpdated; set => categoryUpdated = value; }
        public static string CategoryListed { get => categoryListed; set => categoryListed = value; }
        public static string CategoryDeleted { get => categoryDeleted; set => categoryDeleted = value; }
        public static string OrderAdded { get => orderAdded; set => orderAdded = value; }
        public static string OrderUpdated { get => orderUpdated; set => orderUpdated = value; }
        public static string OrderListed { get => orderListed; set => orderListed = value; }
        public static string OrderDeleted { get => orderDeleted; set => orderDeleted = value; }
        public static string CustomerAdded { get => customerAdded; set => customerAdded = value; }
        public static string CustomerUpdated { get => customerUpdated; set => customerUpdated = value; }
        public static string CustomerListed { get => customerListed; set => customerListed = value; }
        public static string CustomerDeleted { get => customerDeleted; set => customerDeleted = value; }
    }
}
