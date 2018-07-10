namespace BeLife.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contrato")]
    public partial class Contrato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contrato()
        {
            Vivienda = new HashSet<Vivienda>();
            Vehiculo = new HashSet<Vehiculo>();
        }

        [Key]
        [StringLength(14)]
        public string Numero { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaTermino { get; set; }

        [Required]
        [StringLength(10)]
        public string RutCliente { get; set; }

        [Required]
        [StringLength(5)]
        public string CodigoPlan { get; set; }

        public int IdTipoContrato { get; set; }

        public DateTime FechaInicioVigencia { get; set; }

        public DateTime FechaFinVigencia { get; set; }

        public bool Vigente { get; set; }

        public bool DeclaracionSalud { get; set; }

        public double PrimaAnual { get; set; }

        public double PrimaMensual { get; set; }

        [Required]
        public string Observaciones { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Plan Plan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vivienda> Vivienda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
