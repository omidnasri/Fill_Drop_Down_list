using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fill_Drop_Down_list.Models
{
    public class City
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
        public int Province_Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("Province_Id")]
        public virtual Province Province{ get; set; }
    }
}