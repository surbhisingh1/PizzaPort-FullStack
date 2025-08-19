using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaPort.Application.Contracts;
using PizzaPort.Application.DTOs;

namespace PizzaPort.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }
        [HttpGet]
        [Route("GetItems")]
        public async Task<ActionResult<IEnumerable<ItemResponseDTO>>> GetAllItems()
        {
            var result=await _itemService.GetItems();
            return Ok(result);
        }
    }
}
