using System;
using System.Collections.Generic;

namespace Fill_Drop_Down_list.Models
{
    public class Province
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<City> City { get; set; }
    }
}