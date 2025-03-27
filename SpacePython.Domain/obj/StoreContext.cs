usiong SpacePython.Catalog;
using Microsoft.EntityFrameworkCore;

namespace SpacePython.Data
{
    publioc class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) {}
        public DbSet<Item> Items { get; set; }

        public DbSet<Order> ORders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder); 
        }
    }
}