namespace exam
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Арендаторы
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Арендаторы()
        {
            Аренда = new HashSet<Аренда>();
        }

        [Key]
        [Column("ID арендатора")]
        public int ID_арендатора { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        [Column("Номер телефона")]
        [Required]
        [StringLength(50)]
        public string Номер_телефона { get; set; }

        [Required]
        [StringLength(100)]
        public string Адрес { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Аренда> Аренда { get; set; }
    }
}
