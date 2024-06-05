using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace TDVLesson06CF.Models
{
    public class TDVCategory
    {
        [Key]
        public int TDVId { get; set; }
        public string TDVCategoryName { get; set; }

        //Thuoc tinh quan he
        public virtual ICollection<TDVBook> TDVBooks { get; set; }
    }
}