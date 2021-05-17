namespace exam
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Список павильонов")]
    public partial class Список_павильонов
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Список_павильонов()
        {
            Аренда = new HashSet<Аренда>();
        }

        [Key]
        [Column("ID павильона")]
        public int ID_павильона { get; set; }

        public int ТЦ { get; set; }

        [Column("№ павильона")]
        [Required]
        [StringLength(10)]
        public string C__павильона { get; set; }

        public short этаж { get; set; }

        [Required]
        [StringLength(50)]
        public string статус { get; set; }

        public double площадь { get; set; }

        [Column("стоимость за кв.м", TypeName = "money")]
        public decimal стоимость_за_кв_м { get; set; }

        [Column("кооф. добавчной стоимости")]
        public double кооф__добавчной_стоимости { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Аренда> Аренда { get; set; }

        public virtual Список_ТЦ Список_ТЦ { get; set; }
    }
}
