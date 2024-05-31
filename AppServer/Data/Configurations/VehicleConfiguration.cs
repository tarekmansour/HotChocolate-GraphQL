using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppServer;

public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
{
    public void Configure(EntityTypeBuilder<Vehicle> builder)
    {
        builder.ToTable(nameof(Vehicle));

        builder.HasKey(x => x.Id);

        builder.Property(x => x.CountryIsoCodeAlpha2).HasColumnType("[varchar](2)");

        builder.Property(x => x.Vin)
            .IsRequired()
            .HasColumnType("[varchar](17)");

        builder.Property(x => x.Make).HasColumnType("[varchar](50)");
        builder.Property(x => x.Model).HasColumnType("[varchar](50)");
        builder.Property(x => x.Version).HasColumnType("[varchar](50)");
        builder.Property(x => x.Color).HasColumnType("[varchar](50)");
        builder.Property(x => x.MileageUnit).HasColumnType("[varchar](10)");

        builder.HasData(
            new Vehicle
            {
                Id = 1,
                CountryIsoCodeAlpha2 = "FR",
                Vin = "JH4CU2E46CC854694",
                Price = 25000,
                Make = "BMW",
                Model = "Serie 1",
                Version = "abc1",
                Color = "Black",
                ModelYear = 2023,
                Mileage = 4500,
                MileageUnit = "KM"
            },
            new Vehicle
            {
                Id = 2,
                CountryIsoCodeAlpha2 = "DE",
                Vin = "GV4CU2E56TT854647",
                Price = 18500,
                Make = "AUDI",
                Model = "A4",
                Version = "efg2",
                Color = "White",
                ModelYear = 2019,
                Mileage = 26000,
                MileageUnit = "KM"
            }
        );
    }
}
