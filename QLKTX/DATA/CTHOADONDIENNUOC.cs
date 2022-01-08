namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHOADONDIENNUOC")]
    public partial class CTHOADONDIENNUOC
    {
        public int ID { get; set; }

        public double CHISOSUDUNG { get; set; }

        [StringLength(10)]
        public string MABANGGIA { get; set; }

        public int? MAHDDIENNUOC { get; set; }

        public virtual BANGGIADIENNUOC BANGGIADIENNUOC { get; set; }

        public virtual HOADONDIENNUOC HOADONDIENNUOC { get; set; }
    }
}
