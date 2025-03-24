using Microsoft.AspNetCore.Http.HttpResults;
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
        [HttpGet("{id:int}")]
public IActionResult GetItem(int id)
{
    var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
    item.Id = id;

    return Ok(item);
}
[HttpPost]
public IActionResult Post(Item item){
    return Created("/catalog/42", item);
}
[HttpPost("{id:int}/ratings")]
public IActionResult PostRating(int id, [FromBody] UserRating rating){
    var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
    item.Id = id;
    item.AddRating(rating);

    return Ok(item);
}
[HttpPut("{id:int}")]
public IActionResult Put(int id, Item item){
    return NoContent();
}
[HttpDelete("{id:int}")]
public IActionResult Delete(int id){
    return NoContent();
}
    }
    
}

