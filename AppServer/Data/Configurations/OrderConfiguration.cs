using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppServer;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable(nameof(Order));

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasColumnType("[varchar](50)");

        builder
            .HasMany(x => x.Vehicles)
            .WithOne(x => x.Order)
            .HasForeignKey(x => x.OrderId);

        builder.HasData(
            new Order
            {
                Id = 1,
                Name = "NewOrder-124",
                Date = DateTime.Now.AddDays(-1),
                TotalAmount = 45000m
            }
        );
    }
}