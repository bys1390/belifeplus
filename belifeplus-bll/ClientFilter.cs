using BeLife.Data.Models;
using BeLife.Data.Repositories;
using System;
using System.Collections.Generic;

namespace BeLife.Business
{
	public class ClientFilter
	{
		protected IClientRepository Repository { get; }

		public ClientFilter(IClientRepository repo) => Repository = repo;

		public IEnumerable<Cliente> Filter(
			bool doRut = false, string rut = null,
			bool doNombres = false, string nombres = null,
			bool doApellidos = false, string apellidos = null,
			bool doFechaNacimiento = false, DateTime? fechaNacimiento = null,
			bool doSexo = false, string sexo = null,
			bool doEstadoCivil = false, string estadoCivil = null) => throw new NotImplementedException();

		public IEnumerable<Cliente> OrderByRut(IEnumerable<Cliente> input, bool ascending = false) => throw new NotImplementedException();

		public IEnumerable<Cliente> OrderByNombres(IEnumerable<Cliente> input, bool ascending = false) => throw new NotImplementedException();

		public IEnumerable<Cliente> OrderByApellidos(IEnumerable<Cliente> input, bool ascending = false) => throw new NotImplementedException();

		public IEnumerable<Cliente> OrderByFechaNacimiento(IEnumerable<Cliente> input, bool ascending = false) => throw new NotImplementedException();

		public IEnumerable<Cliente> OrderBySexo(IEnumerable<Cliente> input, bool ascending = false) => throw new NotImplementedException();

		public IEnumerable<Cliente> OrderByEstadoCivil(IEnumerable<Cliente> input, bool ascending = false) => throw new NotImplementedException();
	}
}
