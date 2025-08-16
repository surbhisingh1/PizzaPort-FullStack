using AutoMapper;
using PizzaPort.Domain.Entities;
using PizzaPort.Domain.Interfaces;
using PizzaPort.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPort.Infrastructure.Repositories
{
    public class ItemRepository:GenericRepository<ItemDomain,Item>,IItemRepository
    {
        public ItemRepository(PizzaPortDBContext dbContext,IMapper mapper):base(dbContext,mapper) 
        {

        }

        
    }
}
