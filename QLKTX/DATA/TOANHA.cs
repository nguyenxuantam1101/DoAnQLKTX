namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOANHA")]
    public partial class TOANHA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOANHA()
        {
            PHONGSV = new HashSet<PHONGSV>();
        }

        [Key]
        [StringLength(10)]
        public string MATOA { get; set; }

        [StringLength(20)]
        public string TENTOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONGSV> PHONGSV { get; set; }
    }
}
