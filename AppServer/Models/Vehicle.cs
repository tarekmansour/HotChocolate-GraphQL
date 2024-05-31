namespace AppServer;

/// <summary>
/// The vehicle model object.
/// </summary>
public class Vehicle
{
    /// <summary>
    /// The unique identifier.
    /// </summary>
    public required int Id { get; init; }

    /// <summary>
    /// The country ISO code ALPHA-2.
    /// </summary>
    public string? CountryIsoCodeAlpha2 { get; init; }

    /// <summary>
    /// The vin.
    /// </summary>
    public required string Vin { get; init; }

    /// <summary>
    /// The price.
    /// </summary>
    public int Price { get; set; }

    /// <summary>
    /// The make/brand.
    /// </summary>
    public string? Make { get; init; }

    /// <summary>
    /// The model.
    /// </summary>
    public string? Model { get; init; }

    /// <summary>
    /// The version.
    /// </summary>
    public string? Version { get; init; }

    /// <summary>
    /// The color.
    /// </summary>
    public string? Color { get; set; }

    /// <summary>
    /// The model year.
    /// </summary>
    public int ModelYear { get; init; }

    /// <summary>
    /// The mileage.
    /// </summary>
    public int Mileage { get; init; }

    /// <summary>
    /// The mileage unit.
    /// </summary>
    public string? MileageUnit { get; init; }
}
