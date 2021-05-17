namespace exam
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Список ТЦ")]
    public partial class Список_ТЦ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Список_ТЦ()
        {
            Список_павильонов = new HashSet<Список_павильонов>();
        }

        [Key]
        [Column("ID ТЦ")]
        public int ID_ТЦ { get; set; }

        [Column("название ТЦ")]
        [Required]
        [StringLength(50)]
        public string название_ТЦ { get; set; }

        [Required]
        [StringLength(50)]
        public string статус { get; set; }

        [Column("количество павильонов")]
        public short? количество_павильонов { get; set; }

        [Required]
        [StringLength(50)]
        public string город { get; set; }

        [Column("стоимость постройки", TypeName = "money")]
        public decimal стоимость_постройки { get; set; }

        public short? этажность { get; set; }

        [Column("коэффицент добавчной стоимости")]
        public double коэффицент_добавчной_стоимости { get; set; }

        public string изображение { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Список_павильонов> Список_павильонов { get; set; }
    }
}
