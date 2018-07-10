using BeLife.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife.Business
{
	public class ClientManager
	{
		protected IClientRepository Repository { get; }

		public ClientManager(IClientRepository repo) => Repository = repo;

		public bool Add(string rut, string nombres, string apellidos, DateTime fechaNacimiento, string sexo, string estadoCivil, out string message) => throw new NotImplementedException();

		public bool Get(string rut, out string message) => throw new NotImplementedException();

		public bool Modify(string rut, string nombres, string apellidos, DateTime fechaNacimiento, string sexo, string estadoCivil, out string message) => throw new NotImplementedException();

		public bool Delete(string rut, out string message) => throw new NotImplementedException();
	}
}
