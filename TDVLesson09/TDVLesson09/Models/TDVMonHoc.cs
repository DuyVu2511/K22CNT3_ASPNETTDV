//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TDVLesson09.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TDVMonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TDVMonHoc()
        {
            this.TDVKetquas = new HashSet<TDVKetqua>();
        }
    
        public string TDVMaMH { get; set; }
        public string TDVTenMH { get; set; }
        public Nullable<int> TDVSotiet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TDVKetqua> TDVKetquas { get; set; }
    }
}
