namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGGIADIENNUOC")]
    public partial class BANGGIADIENNUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANGGIADIENNUOC()
        {
            CTHOADONDIENNUOC = new HashSet<CTHOADONDIENNUOC>();
        }

        [Key]
        [StringLength(10)]
        public string MABANGGIA { get; set; }

        [StringLength(10)]
        public string TENDICHVU { get; set; }

        public double GIATHANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOADONDIENNUOC> CTHOADONDIENNUOC { get; set; }
    }
}
