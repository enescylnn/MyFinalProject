using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static yapılar new'lenmemek içindir.
    public static class Messages
    {
        //public olanlar pascal case yazılır.
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımdadır. Lütfen bekleyiniz.";
        public static string ProductsListed= "Ürünler listelendi.";
    }
}
