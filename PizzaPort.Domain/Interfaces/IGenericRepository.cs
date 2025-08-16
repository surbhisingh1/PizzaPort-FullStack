using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPort.Domain.Interfaces
{
    public interface IGenericRepository<TDomain> where TDomain : class
    {
        public Task AddAsyn(TDomain DomainEntity);
        public Task<IEnumerable<TDomain>> GetAllAsync();
        public Task<int> CommitAsync(); 
    }
}
