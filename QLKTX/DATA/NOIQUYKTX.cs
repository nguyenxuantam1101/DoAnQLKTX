namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NOIQUYKTX")]
    public partial class NOIQUYKTX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NOIQUYKTX()
        {
            CTKYLUAT = new HashSet<CTKYLUAT>();
        }

        [Key]
        [StringLength(10)]
        public string MANOIQUY { get; set; }

        [Required]
        [StringLength(50)]
        public string TENNOIQUY { get; set; }

        [StringLength(50)]
        public string NOIDUNG { get; set; }

        [StringLength(50)]
        public string HINHTHUCPHAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTKYLUAT> CTKYLUAT { get; set; }
    }
}
