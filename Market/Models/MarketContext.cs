using Microsoft.EntityFrameworkCore;

namespace Market.Models
{
  public class MarketContext : DbContext
  {
    public virtual DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavor { get; set; }

    public MarketContext(DbContextOptions options) : base(options) { }
  }
}
