using Microsoft.AspNetCore.Mvc;

namespace Task_Talha.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var items = new List<Item>
        {
            new Item { Id = 1, Name = "Item 1" },
            new Item { Id = 2, Name = "Item 2" },
            new Item { Id = 3, Name = "Item 3" },
            new Item { Id = 4, Name = "Item 4" },
            new Item { Id = 5, Name = "Item 5" },
            new Item { Id = 6, Name = "Item 6" },

        };

            return Ok(items);
        }

        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
