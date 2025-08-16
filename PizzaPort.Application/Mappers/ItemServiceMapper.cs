using AutoMapper;
using PizzaPort.Application.DTOs;
using PizzaPort.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPort.Application.Mappers
{
    public class ItemServiceMapper:Profile
    {
        public ItemServiceMapper()
        {
            CreateMap<ItemDomain, ItemResponseDTO>().ForMember(dest=>dest.ItemName,opt=>opt.MapFrom(src=>src.Name));
        }
    }
}
