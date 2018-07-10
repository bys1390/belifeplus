using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeLife.Data.Models;

namespace BeLife.Data.Repositories
{
	public class ClientRepository : IClientRepository
	{
		public void Add(Cliente cliente) => throw new NotImplementedException();
		public void DeleteAll() => throw new NotImplementedException();
		public Boolean DeleteSingle(String rut) => throw new NotImplementedException();
		public IEnumerable<Cliente> GetAll() => throw new NotImplementedException();
		public Cliente GetSingleOrDefault(String rut) => throw new NotImplementedException();
		public Boolean Modify(String rut, Cliente value) => throw new NotImplementedException();
	}
}
