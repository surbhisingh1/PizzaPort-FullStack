using PizzaPort.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPort.Domain.Interfaces
{
    public interface IItemRepository:IGenericRepository<ItemDomain>
    {
    }
}
