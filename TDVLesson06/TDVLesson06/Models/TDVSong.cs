using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TDVLesson06.Models
{
    public class TDVSong
    {
        [Key]
        public double Id { get; set; }

        [Required(ErrorMessage = "TDV: Hay nhap tieu de")]
        [DisplayName("Tieu de")]
        
        public string TDVTitle { get; set; }

        [Required(ErrorMessage = "TDV: Hay nhap tac gia")]
        [DisplayName("Tac gia")]
        public string TDVAuthor { get; set; }

        [Required(ErrorMessage = "TDV: Hay nhap nghe si")]
        [StringLength (50,MinimumLength =2,ErrorMessage ="TDV: Ten nghe si co toi thieu 2 ky tu, toi da 50 ky tu")]
        [DisplayName("Nghe si")]
        public string TDVArtist { get; set; }

        [Required(ErrorMessage = "TDV: Hay nhap nam xuat ban")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="TDV: Nam xuat ban phai co 2 ky tu so")]
        [Range(1900,2024,ErrorMessage ="TDV: Nam xuat ban trong khoang 1900-2024")]
        [DisplayName("Nam xuat ban")]
        public int TDVYearRelease { get; set; }
    }
}