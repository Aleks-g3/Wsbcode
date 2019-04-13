namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trening")]
    public partial class Trening
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string uLogin { get; set; }

        [Column(TypeName = "text")]
        public string csv { get; set; }
    }
}
