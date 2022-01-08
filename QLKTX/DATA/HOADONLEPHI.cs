namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONLEPHI")]
    public partial class HOADONLEPHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONLEPHI()
        {
            CTHOADONLEPHI = new HashSet<CTHOADONLEPHI>();
        }

        [Key]
        public int MAHDLEPHI { get; set; }

        public DateTime HANCUOI { get; set; }

        public DateTime? NGAYLAP { get; set; }

        public double? TONGTIEN { get; set; }

        [StringLength(20)]
        public string TRANGTHAI { get; set; }

        [StringLength(20)]
        public string MANV { get; set; }

        [StringLength(13)]
        public string CCCD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOADONLEPHI> CTHOADONLEPHI { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
