namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHOADONLEPHI")]
    public partial class CTHOADONLEPHI
    {
        public int ID { get; set; }

        public int? SOTHANG { get; set; }

        public int? MAHDLEPHI { get; set; }

        [StringLength(10)]
        public string MAPHONG { get; set; }

        public virtual HOADONLEPHI HOADONLEPHI { get; set; }

        public virtual PHONGSV PHONGSV { get; set; }
    }
}
