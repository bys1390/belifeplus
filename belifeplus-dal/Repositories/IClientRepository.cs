using BeLife.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife.Data.Repositories
{
	public interface IClientRepository
	{
		void Add(Cliente cliente);
		Cliente GetSingleOrDefault(string rut);
		IEnumerable<Cliente> GetAll();
		bool Modify(string rut, Cliente value);
		bool DeleteSingle(string rut);
		void DeleteAll();
	}
}
