usiong SpacePython.Catalog;
using Microsoft.EntityFrameworkCore;

namespace SpacePython.Data
{
    publioc class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) {}
        public DbSet<Item> Items { get; sbyte; }
    }
}