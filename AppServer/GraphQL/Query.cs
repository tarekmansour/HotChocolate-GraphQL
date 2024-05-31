namespace AppServer;

public class Query
{
    public IQueryable<Vehicle> GetVehicles(ApplicationDbContext context)
        => context.Vehicles;
}
