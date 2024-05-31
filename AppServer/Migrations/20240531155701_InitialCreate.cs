using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppServer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryIsoCodeAlpha2 = table.Column<string>(type: "[varchar](2)", nullable: true),
                    Vin = table.Column<string>(type: "[varchar](17)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Make = table.Column<string>(type: "[varchar](50)", nullable: true),
                    Model = table.Column<string>(type: "[varchar](50)", nullable: true),
                    Version = table.Column<string>(type: "[varchar](50)", nullable: true),
                    Color = table.Column<string>(type: "[varchar](50)", nullable: true),
                    ModelYear = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    MileageUnit = table.Column<string>(type: "[varchar](10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "Id", "Color", "CountryIsoCodeAlpha2", "Make", "Mileage", "MileageUnit", "Model", "ModelYear", "Price", "Version", "Vin" },
                values: new object[,]
                {
                    { 1, "Black", "FR", "BMW", 4500, "KM", "Serie 1", 2023, 25000, "abc1", "JH4CU2E46CC854694" },
                    { 2, "White", "DE", "AUDI", 26000, "KM", "A4", 2019, 18500, "efg2", "GV4CU2E56TT854647" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
