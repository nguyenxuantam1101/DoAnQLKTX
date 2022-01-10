namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            ACCOUNT = new HashSet<ACCOUNT>();
            HOADONDIENNUOC = new HashSet<HOADONDIENNUOC>();
            HOADONLEPHI = new HashSet<HOADONLEPHI>();
        }

        [Key]
        [StringLength(20)]
        public string MANV { get; set; }

        [StringLength(50)]
        public string HOTENNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYSINH { get; set; }

        [StringLength(10)]
        public string GIOITINH { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(50)]
        public string CHUCVU { get; set; }

        public double? LUONG { get; set; }

        [StringLength(20)]
        public string TRANGTHAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACCOUNT> ACCOUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONDIENNUOC> HOADONDIENNUOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONLEPHI> HOADONLEPHI { get; set; }
    }
}
