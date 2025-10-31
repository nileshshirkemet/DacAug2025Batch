using Microsoft.EntityFrameworkCore;

namespace DemoApp.Tourism.Data;

public class SiteDbContext : DbContext
{
    public DbSet<Traveller> Travellers { get; set; }

    public SiteDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=site.db");
    }
}