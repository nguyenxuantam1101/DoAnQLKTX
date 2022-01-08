namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KYLUAT")]
    public partial class KYLUAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KYLUAT()
        {
            CTKYLUAT = new HashSet<CTKYLUAT>();
        }

        [Key]
        [StringLength(20)]
        public string MAKYLUAT { get; set; }

        [StringLength(13)]
        public string CCCD { get; set; }

        [StringLength(20)]
        public string MANV { get; set; }

        public DateTime NGAYKYLUAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTKYLUAT> CTKYLUAT { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
