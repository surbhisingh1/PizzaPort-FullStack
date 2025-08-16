using AutoMapper;
using PizzaPort.Domain.Entities;
using PizzaPort.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPort.Infrastructure.Mappers
{
    public class ItemMappingExtension:Profile
    {
        public ItemMappingExtension() 
        {
           //CreateMap<Item,ItemDomain>();
            CreateMap<ItemDomain, Item>().ReverseMap();
        }
    }
}
