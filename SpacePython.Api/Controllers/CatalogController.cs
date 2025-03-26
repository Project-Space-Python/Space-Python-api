using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SpacePython.Domain.Catalog;
using SpacePython.Data;

namespace SpacePython.Api.Controllers
{
    [ApiController]
    [Route("/catalog")]
    public class CatalogController : ControllerBase
    {
        private readonly StoreContext _db;

        public CatalogController(StoreContext db)
        {
            _db = db;
        }
        public CatalogController()
        {
            Console.WriteLine("CatalogController initialized");
        }
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok(_db.Items);
        }
        [HttpGet("{id:int}")]
public IActionResult GetItem(int id)
{
    var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
    item.Id = id;

    return Ok(_db.Items);
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
public DbSet<Item> Items {get; set; }

protected override void OnModelCreating(ModelBuilder builder)
{
    base.OnModelCreating(builder);
    DbInitializer.Initialize(builder);
}
    }
    
}

