using Microsoft.AspNetCore.Mvc;
using SpacePython.Domain.Catalog;

namespace SpacePython.Api.Controllers
{
    [ApiController]
    [Route("catalog")]
    public class CatalogController : ControllerBase
    {
        public CatalogController()
        {
            Console.WriteLine("CatalogController initialized");
        }
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("hello world.");
        }
    }
}
