//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TDVBaiKiemTraGiuaKy.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TDVSinhVien
    {
        public string TDVMaSV { get; set; }
        public string TDVHoSV { get; set; }
        public string TDVTenSV { get; set; }
        public Nullable<System.DateTime> TvcNgaySinh { get; set; }
        public Nullable<bool> TDVPhai { get; set; }
        public string TDVPhone { get; set; }
        public string TDVEmail { get; set; }
        public string TDVMaKH { get; set; }
    
        public virtual TDVKhoa TDVKhoa { get; set; }
    }
}
