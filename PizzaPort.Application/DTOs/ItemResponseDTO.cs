using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPort.Application.DTOs
{
    public class ItemResponseDTO
    {
        public string ItemName { get; set; }

        public string Description { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
