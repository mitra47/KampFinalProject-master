using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductUpdate = "Ürün Güncenlendi";
        public static string ProductDelete = "Ürün Silindi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir ürün Kategerosine En Fazla 10 Ürün Ekeleybilirsiniz";
        public static string ProductNameAlreadyExists="Aynı ürün ismini Bullunmakatadır";
        public static string CategoryLimitExceded="Kategori Sayısı 15'i gecemez";
    }
}
