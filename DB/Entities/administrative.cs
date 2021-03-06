namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.IO;

    [Table("spkmodel.administratives")]
    public partial class administrative
    {
        public int id { get; set; }

        [StringLength(255)]
        public string school_name { get; set; }

        [StringLength(255)]
        public string school_motto { get; set; }

        [StringLength(255)]
        public string school_logo { get; set; }

        [StringLength(255)]
        public string school_stamp { get; set; }

        [StringLength(50)]
        public string upload_date { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? upload_time { get; set; }
    }
}
