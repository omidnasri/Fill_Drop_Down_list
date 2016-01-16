using System;
using System.Collections.Generic;

namespace Fill_Drop_Down_list.Models
{
    /// <summary>
    /// دیتابیس
    /// </summary>
    public static class Database
    {
        /// <summary>
        /// لیست استان‌ها
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Province> GetProvince()
        {
            return new List<Province>()
            {
                new Province() {Id = 1, Name = "کردستان"}
                 , new Province() {Id = 2, Name = "تهران"}
                  , new Province() { Id = 3, Name = "فارس"}
            };
        }
        /// <summary>
        /// لیست شهرستان‌ها
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<City> FindCity()
        {
            return new List<City>()
            {
                new City() {Id = 1, Name = "سنندج", Province_Id = 1}
                 , new City() {Id = 2, Name = "مریوان", Province_Id = 1}
                  , new City() {Id = 3, Name = "رباط کریم", Province_Id = 2}
                   , new City() {Id = 4, Name = "مرودشت", Province_Id = 3}
            };
        }
    }
}