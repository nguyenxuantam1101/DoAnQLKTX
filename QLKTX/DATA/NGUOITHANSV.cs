namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOITHANSV")]
    public partial class NGUOITHANSV
    {
        [Key]
        public int MANT { get; set; }

        [StringLength(30)]
        public string TENNGUOITHAN { get; set; }

        [StringLength(10)]
        public string QUANHEVOISV { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string DIACHI { get; set; }

        [StringLength(13)]
        public string CCCD { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
