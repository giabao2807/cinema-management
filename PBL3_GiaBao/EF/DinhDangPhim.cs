//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3_GiaBao.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class DinhDangPhim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DinhDangPhim()
        {
            this.LichChieux = new HashSet<LichChieu>();
        }
    
        public string id { get; set; }
        public string idPhim { get; set; }
        public string idPhongChieu { get; set; }
    
        public virtual Phim Phim { get; set; }
        public virtual PhongChieu PhongChieu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichChieu> LichChieux { get; set; }
    }
}
