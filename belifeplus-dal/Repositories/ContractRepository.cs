using System.Collections.Generic;
using BeLife.Data.Models;

namespace BeLife.Data.Repositories
{
	public class ContractRepository : IContractRepository
	{
		public void Add(Contrato contract) => throw new System.NotImplementedException();
		public void DeleteAll() => throw new System.NotImplementedException();
		public System.Boolean DeleteSingle(System.String code) => throw new System.NotImplementedException();
		public IEnumerable<Contrato> GetAll() => throw new System.NotImplementedException();
		public Contrato GetSingleOrDefault(System.String code) => throw new System.NotImplementedException();
		public System.Boolean Modify(System.String code, Contrato value) => throw new System.NotImplementedException();
	}
}
