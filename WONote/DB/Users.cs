namespace DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string Username { get; set; }

        [StringLength(10)]
        public string Surame { get; set; }

        [StringLength(10)]
        public string uLogin { get; set; }

        [StringLength(10)]
        public string Mail { get; set; }

        [StringLength(10)]
        public string Passwd { get; set; }
    }
}
