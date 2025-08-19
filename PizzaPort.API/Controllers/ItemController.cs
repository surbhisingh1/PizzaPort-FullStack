using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaPort.Application.Contracts;
using PizzaPort.Application.DTOs;

namespace PizzaPort.API.Controllers
{
    [Route("api/[controller]/[action]")]
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
            var result = await _itemService.GetItemsAsync();
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ItemResponseDTO>> GetItemById(int id)
        {
            var item=await _itemService.GetItemByIdAsync(id);
            return Ok(item);
        }


    }
}
