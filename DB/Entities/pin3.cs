namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("spkmodel.pin3")]
    public partial class pin3
    {
        public int id { get; set; }

        [StringLength(20)]
        public string term { get; set; }

        [StringLength(50)]
        public string third_term_pin { get; set; }

        [StringLength(50)]
        public string serial_number { get; set; }

        [StringLength(50)]
        public string upload_date { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime upload_time { get; set; }
    }
}
