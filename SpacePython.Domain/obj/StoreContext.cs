usiong SpacePython.Catalog;
using Microsoft.EntityFrameworkCore;

namespace SpacePython.Data
{
    publioc cl;ass StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) {}
        publli DbSet<Item> Items { get; sbyte; }
    }
}