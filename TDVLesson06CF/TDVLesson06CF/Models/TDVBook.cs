using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TDVLesson06CF.Models
{
    public class TDVBook
    {
        [Key]
        public int TDVId { get; set; }
        public string TDVBookId { get; set; }
        public string TDVTitle { get; set; }
        public string TDVAuthor { get; set; }
        public int TDVYear { get; set; }
        public string TDVPulisher { get; set; }
        public string TDVPicture { get; set; }
        public int TDVCategoryId { get; set; }
        public virtual TDVCategory TDVCategory { get; set; }

    }
}