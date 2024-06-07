namespace AppServer;

[GraphQLDescription("The Query type.")]
public class Query
{
    [GraphQLDescription("Represents vehicles list.")]
    public IQueryable<Vehicle> GetVehicles(ApplicationDbContext context)
        => context.Vehicles;

    [GraphQLDescription("Represents the orders with vehicles.")]
    [UseProjection]
    public IQueryable<Order> GetOrders(ApplicationDbContext context)
        => context.Orders;
}
