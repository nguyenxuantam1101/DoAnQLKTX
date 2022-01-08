namespace QLKTX.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTKYLUAT")]
    public partial class CTKYLUAT
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string MAKYLUAT { get; set; }

        [StringLength(10)]
        public string MANOIQUY { get; set; }

        public virtual KYLUAT KYLUAT { get; set; }

        public virtual NOIQUYKTX NOIQUYKTX { get; set; }
    }
}
