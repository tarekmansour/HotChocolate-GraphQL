using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppServer.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "[varchar](50)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "Date", "Name", "TotalAmount" },
                values: new object[] { 1, new DateTime(2024, 5, 30, 22, 15, 13, 937, DateTimeKind.Local).AddTicks(2221), "NewOrder-124", 45000m });

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Vehicle",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_OrderId",
                table: "Vehicle",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Order_OrderId",
                table: "Vehicle",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Order_OrderId",
                table: "Vehicle");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_OrderId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Vehicle");
        }
    }
}
