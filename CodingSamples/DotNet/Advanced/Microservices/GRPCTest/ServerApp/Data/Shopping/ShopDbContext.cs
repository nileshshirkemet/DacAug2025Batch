using Microsoft.EntityFrameworkCore;

namespace ServerApp.Data.Shopping;

public class ShopDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Order> Orders { get; set; }

    public DbSet<Counter> Counters { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .ToTable("OrderDetail")
            .HasKey(nameof(Order.OrderNo));
    }
}