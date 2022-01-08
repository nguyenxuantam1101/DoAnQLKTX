namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRUONGHOC")]
    public partial class TRUONGHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRUONGHOC()
        {
            SINHVIEN = new HashSet<SINHVIEN>();
        }

        [Key]
        [StringLength(20)]
        public string MATRUONG { get; set; }

        [StringLength(30)]
        public string TENTRUONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIEN> SINHVIEN { get; set; }
    }
}
