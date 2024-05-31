namespace AppServer;

/// <summary>
/// The order model object.
/// </summary>
public class Order
{
    /// <summary>
    /// The order unique identifier.
    /// </summary>
    public int Id { get; init; }

    /// <summary>
    /// The order name.
    /// <summary>
    public string? Name { get; set; }

    /// <summary>
    /// The Date and time when the order was placed.
    /// <summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// The total amount for the order, including taxes and discounts.
    /// <summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// The vehicles list for an order.
    /// <summary>
    public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
