namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Key]
        [StringLength(32)]
        public string USER { get; set; }

        [Required]
        [StringLength(32)]
        public string PASS { get; set; }

        [Required]
        [StringLength(10)]
        public string QUYEN { get; set; }

        [StringLength(20)]
        public string MANV { get; set; }

        [StringLength(13)]
        public string CCCD { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
