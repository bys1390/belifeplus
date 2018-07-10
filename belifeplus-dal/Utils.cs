using BeLife.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace BeLife.Data
{
	public static class Utils
	{
		public static BeLifeContext Context { get; } = new BeLifeContext();

		public static IEnumerable<EstadoCivil> GetAllEstadoCivil() => Context.EstadoCivil.ToList();
		public static IEnumerable<Region> GetAllRegion() => Context.Region.ToList();
		public static IEnumerable<Comuna> GetAllComuna() => Context.Comuna.ToList();
		public static IEnumerable<MarcaVehiculo> GetAllMarca() => Context.MarcaVehiculo.ToList();
		public static IEnumerable<ModeloVehiculo> GetAllModelo() => Context.ModeloVehiculo.ToList();
		public static IEnumerable<TipoContrato> GetAllTipoContrato() => Context.TipoContrato.ToList();
	}
}
