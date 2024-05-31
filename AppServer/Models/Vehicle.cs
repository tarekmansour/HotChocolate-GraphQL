namespace AppServer;

public class Vehicle
{
    public required int Id { get; init; }
    public string? CountryIsoCodeAlpha2 { get; init; }
    public required string Vin { get; init; }
    public int Price { get; set; }
    public string? Make { get; init; }
    public string? Model { get; init; }
    public string? Version { get; init; }
    public string? Color { get; set; }
    public int ModelYear { get; init; }
    public int Mileage { get; init; }
    public string? MileageUnit { get; init; }
}
