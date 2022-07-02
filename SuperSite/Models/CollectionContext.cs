using Microsoft.EntityFrameworkCore;
using SuperSite.Models;

namespace SuperSite.Models;

public class CollectionContext : DbContext
{
    public CollectionContext(DbContextOptions<CollectionContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Item> CollectionItems => Set<Item>();
}