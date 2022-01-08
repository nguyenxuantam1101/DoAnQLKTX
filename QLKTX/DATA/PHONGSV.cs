namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONGSV")]
    public partial class PHONGSV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONGSV()
        {
            CTHOADONLEPHI = new HashSet<CTHOADONLEPHI>();
            HOADONDIENNUOC = new HashSet<HOADONDIENNUOC>();
            SINHVIEN = new HashSet<SINHVIEN>();
        }

        [Key]
        [StringLength(10)]
        public string MAPHONG { get; set; }

        [StringLength(50)]
        public string TENPHONG { get; set; }

        [StringLength(30)]
        public string LOAIPHONG { get; set; }

        public int? SOLUONG { get; set; }

        public double? GIAPHONG { get; set; }

        [StringLength(30)]
        public string TRANGTHAI { get; set; }

        [StringLength(10)]
        public string MATOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOADONLEPHI> CTHOADONLEPHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONDIENNUOC> HOADONDIENNUOC { get; set; }

        public virtual TOANHA TOANHA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIEN> SINHVIEN { get; set; }
    }
}
