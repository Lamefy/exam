namespace exam
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Аренда
    {
        [Key]
        [Column("ID аренды")]
        public int ID_аренды { get; set; }

        [Column("ID арендатора")]
        public int ID_арендатора { get; set; }

        [Column("ID сотрудника")]
        public int ID_сотрудника { get; set; }

        [Column("ID павильона")]
        public int ID_павильона { get; set; }

        [Required]
        [StringLength(50)]
        public string Статус { get; set; }

        [Column("Начало аренды", TypeName = "date")]
        public DateTime Начало_аренды { get; set; }

        [Column("Окончание аренды", TypeName = "date")]
        public DateTime Окончание_аренды { get; set; }

        public virtual Арендаторы Арендаторы { get; set; }

        public virtual Сотрудники Сотрудники { get; set; }

        public virtual Список_павильонов Список_павильонов { get; set; }
    }
}
