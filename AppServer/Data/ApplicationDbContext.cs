using Microsoft.EntityFrameworkCore;

namespace AppServer;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Order> Orders { get; set; }
}
