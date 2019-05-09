namespace OOP9
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERS")]
    public partial class USER
    {
        [Key]
        public int USER_ID { get; set; }

        [Required]
        [StringLength(15)]
        public string LOGIN { get; set; }

        [Required]
        [StringLength(40)]
        public string PASSWORD_HASH { get; set; }
    }
}
