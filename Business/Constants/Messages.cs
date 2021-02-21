using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static for use without new()
    public static class Messages
    {
        //Car
        public static string CarAdded = "Araç Eklendi";
        public static string CarUpdated = "Araç Güncellendi";
        public static string CarDeleted = "Araç Silindi";
        public static string CarReturnedById = "Araç gönderilen ID için getirildi";
        public static string CarNameInvalid = "Araç İsmi Geçersiz";
        public static string CarsListed = "Araçlar Listelendi";
        public static string CarsListedByBrandId = "Araçlar Markaya Göre Listelendi";
        public static string CarsListedByColorId = "Araçlar Renklerine Göre Listelendi";
        public static string CarsListedByDailyPrice = "Araçlar Günlük Ücretlerine Göre Listelendi";
        public static string CarsListedByModelYear = "Araçlar Model Yılına Göre Listelendi";
        public static string CarDetailsListed = "Araç Detayları Listelendi";
        //Brand
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandsListed = "Markalar Listelendi";
        public static string BrandsListedById = "Marka ID için Gönderildi";
        public static string BrandUpdated = "Marka Güncellendi";
        //Color
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorsListed = "Renkler Listelendi";
        public static string ColorsListedById = "Renk ID için Gönderildi";
        //Customer
        public static string CustomerAdded = "Müşteri Eklendi";
        internal static string CustomerDeleted;
        internal static string CustomerListed;
        internal static string CustomerUpdated;
        internal static string CustomerReturnedById;
        internal static string RentalAdded;
        internal static string RentalError;
        internal static string RentalDeleted;
        internal static string RentalUpdated;
        internal static string UserAdded;
        internal static string UserDeleted;
        internal static string UsersListed;
        internal static string UserUpdated;
        internal static string UserReturnedById;
    }
}
