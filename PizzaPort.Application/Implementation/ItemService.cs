using AutoMapper;
using PizzaPort.Application.Contracts;
using PizzaPort.Application.DTOs;
using PizzaPort.Domain.Entities;
using PizzaPort.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPort.Application.Implementation
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;
        private readonly IMapper _mappers;

        public ItemService(IItemRepository itemRepository,IMapper mappers)
        {
            _itemRepository = itemRepository;
            _mappers = mappers;
        }

        public async Task<ItemResponseDTO> GetItemByIdAsync(int id)
        {
            ItemDomain? selectedItem=await _itemRepository.GetByIdAsync(id);
            var obj=_mappers.Map<ItemResponseDTO>(selectedItem);
            return obj;
           
        }

        public async Task<IEnumerable<ItemResponseDTO>> GetItemsAsync()
        {
           IEnumerable<ItemDomain> result= await _itemRepository.GetAllAsync();
            //List<ItemResponseDTO> items= new List<ItemResponseDTO>();
            //foreach (Item itm in result)
            //{
            //    items.Add(new ItemResponseDTO { ItemName = itm.Name,Description=itm.Description,UnitPrice=itm.UnitPrice });
                
            //}
            //return items;

            var items=_mappers.Map<IEnumerable<ItemResponseDTO>>(result);
            return items;

            
        }
        
    }
}
