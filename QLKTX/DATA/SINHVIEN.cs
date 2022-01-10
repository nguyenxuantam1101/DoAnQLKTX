namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            ACCOUNT = new HashSet<ACCOUNT>();
            HOADONLEPHI = new HashSet<HOADONLEPHI>();
            NGUOITHANSV = new HashSet<NGUOITHANSV>();
        }

        [Key]
        [StringLength(13)]
        public string CCCD { get; set; }

        [StringLength(11)]
        public string MSSV { get; set; }

        [StringLength(30)]
        public string HOTEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime NAMSINH { get; set; }

        [StringLength(10)]
        public string GIOITINH { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(30)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        public DateTime? NGAYVAOKTX { get; set; }

        public DateTime? NGAYRAKTX { get; set; }

        [StringLength(20)]
        public string TRANGTHAI { get; set; }

        [StringLength(10)]
        public string MAPHONG { get; set; }

        [StringLength(20)]
        public string MATRUONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACCOUNT> ACCOUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONLEPHI> HOADONLEPHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOITHANSV> NGUOITHANSV { get; set; }

        public virtual PHONGSV PHONGSV { get; set; }

        public virtual TRUONGHOC TRUONGHOC { get; set; }
    }
}
