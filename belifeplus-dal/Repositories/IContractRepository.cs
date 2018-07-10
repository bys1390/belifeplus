using BeLife.Data.Models;
using System.Collections.Generic;

namespace BeLife.Data.Repositories
{
	public interface IContractRepository
	{
		void Add(Contrato contract);
		Contrato GetSingleOrDefault(string code);
		IEnumerable<Contrato> GetAll();
		bool Modify(string code, Contrato value);
		bool DeleteSingle(string code);
		void DeleteAll();
	}
}
