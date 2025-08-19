using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPort.Application.DTOs
{
    public class ItemResponseDTO
    {
        public string ItemName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public decimal UnitPrice { get; set; }
        public string ImageUrl { get; set; } = default!;
    }
}
