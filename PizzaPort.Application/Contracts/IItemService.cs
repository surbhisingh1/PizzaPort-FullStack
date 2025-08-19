using PizzaPort.Application.DTOs;
using PizzaPort.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPort.Application.Contracts
{
    public interface IItemService
    {

        public Task<IEnumerable<ItemResponseDTO>> GetItems();
        
    }
}
