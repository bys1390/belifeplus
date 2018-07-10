namespace BeLife.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vivienda")]
    public partial class Vivienda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vivienda()
        {
            Contrato = new HashSet<Contrato>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoPostal { get; set; }

        public int Anho { get; set; }

        [Required]
        [StringLength(20)]
        public string Direccion { get; set; }

        public double ValorInmueble { get; set; }

        public double ValorContenido { get; set; }

        public int IdRegion { get; set; }

        public int IdComuna { get; set; }

        public virtual RegionComuna RegionComuna { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrato> Contrato { get; set; }
    }
}
