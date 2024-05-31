namespace AppServer;

/// <summary>
/// The Query type.
/// </summary>
public class Query
{
    /// <summary>
    /// Vehicles connection.
    /// </summary>
    public IQueryable<Vehicle> GetVehicles(ApplicationDbContext context)
        => context.Vehicles;

    /// <summary>
    /// Orders with vehicles connection.
    /// </summary>
    [UseProjection]
    public IQueryable<Order> GetOrders(ApplicationDbContext context)
        => context.Orders;
}
