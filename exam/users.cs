namespace exam
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        [Key]
        [StringLength(50)]
        public string login { get; set; }

        [Required]
        [StringLength(50)]
        public string psw { get; set; }

        [Required]
        [StringLength(50)]
        public string role { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
    }
}
