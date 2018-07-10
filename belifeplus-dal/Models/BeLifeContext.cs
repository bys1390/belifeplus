namespace BeLife.Data.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class BeLifeContext : DbContext
	{
		public BeLifeContext()
			: base("name=BeLifeContext")
		{
		}

		public virtual DbSet<Cliente> Cliente { get; set; }
		public virtual DbSet<Comuna> Comuna { get; set; }
		public virtual DbSet<Contrato> Contrato { get; set; }
		public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
		public virtual DbSet<MarcaModeloVehiculo> MarcaModeloVehiculo { get; set; }
		public virtual DbSet<MarcaVehiculo> MarcaVehiculo { get; set; }
		public virtual DbSet<ModeloVehiculo> ModeloVehiculo { get; set; }
		public virtual DbSet<Plan> Plan { get; set; }
		public virtual DbSet<Region> Region { get; set; }
		public virtual DbSet<RegionComuna> RegionComuna { get; set; }
		public virtual DbSet<Sexo> Sexo { get; set; }
		public virtual DbSet<TipoContrato> TipoContrato { get; set; }
		public virtual DbSet<Vehiculo> Vehiculo { get; set; }
		public virtual DbSet<Vivienda> Vivienda { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cliente>()
				.HasMany(e => e.Contrato)
				.WithRequired(e => e.Cliente)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Comuna>()
				.HasMany(e => e.RegionComuna)
				.WithRequired(e => e.Comuna)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Contrato>()
				.HasMany(e => e.Vivienda)
				.WithMany(e => e.Contrato)
				.Map(m => m.ToTable("Contrato_Vivienda").MapLeftKey("Numero").MapRightKey("CodigoPostal"));

			modelBuilder.Entity<Contrato>()
				.HasMany(e => e.Vehiculo)
				.WithMany(e => e.Contrato)
				.Map(m => m.ToTable("ContratoVehiculo").MapLeftKey("Numero").MapRightKey("Patente"));

			modelBuilder.Entity<EstadoCivil>()
				.HasMany(e => e.Cliente)
				.WithRequired(e => e.EstadoCivil)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<MarcaModeloVehiculo>()
				.HasMany(e => e.Vehiculo)
				.WithRequired(e => e.MarcaModeloVehiculo)
				.HasForeignKey(e => new { e.IdMarca, e.IdModelo })
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<MarcaVehiculo>()
				.HasMany(e => e.MarcaModeloVehiculo)
				.WithRequired(e => e.MarcaVehiculo)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ModeloVehiculo>()
				.HasMany(e => e.MarcaModeloVehiculo)
				.WithRequired(e => e.ModeloVehiculo)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Plan>()
				.HasMany(e => e.Contrato)
				.WithRequired(e => e.Plan)
				.HasForeignKey(e => new { e.CodigoPlan, e.IdTipoContrato })
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Region>()
				.HasMany(e => e.RegionComuna)
				.WithRequired(e => e.Region)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<RegionComuna>()
				.HasMany(e => e.Vivienda)
				.WithRequired(e => e.RegionComuna)
				.HasForeignKey(e => new { e.IdRegion, e.IdComuna })
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Sexo>()
				.HasMany(e => e.Cliente)
				.WithRequired(e => e.Sexo)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<TipoContrato>()
				.HasMany(e => e.Plan)
				.WithRequired(e => e.TipoContrato)
				.WillCascadeOnDelete(false);
		}
	}
}
