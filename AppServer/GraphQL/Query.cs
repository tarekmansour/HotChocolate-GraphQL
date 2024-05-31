namespace AppServer;

/// <summary>
/// The Query type.
/// </summary>
public class Query
{
    /// <summary>
    /// Get the vehicles list.
    /// </summary>
    public IQueryable<Vehicle> GetVehicles(ApplicationDbContext context)
        => context.Vehicles;
}
