namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONDIENNUOC")]
    public partial class HOADONDIENNUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONDIENNUOC()
        {
            CTHOADONDIENNUOC = new HashSet<CTHOADONDIENNUOC>();
        }

        [Key]
        public int MAHDDIENNUOC { get; set; }

        public DateTime? NGAYLAP { get; set; }

        [StringLength(10)]
        public string MAPHONG { get; set; }

        public double? TONGTIEN { get; set; }

        [StringLength(20)]
        public string MANV { get; set; }

        [StringLength(20)]
        public string TRANGTHAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOADONDIENNUOC> CTHOADONDIENNUOC { get; set; }

        public virtual PHONGSV PHONGSV { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
