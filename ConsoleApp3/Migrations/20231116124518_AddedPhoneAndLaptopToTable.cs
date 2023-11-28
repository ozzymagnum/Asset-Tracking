using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp3.Migrations
{
    /// <inheritdoc />
    public partial class AddedPhoneAndLaptopToTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "Id", "Model", "Price", "PurchaseDate" },
                values: new object[,]
                {
                    { 1, "Lenovo", 5500m, new DateTime(2010, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "MAC", 8000m, new DateTime(2014, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "HP", 3455m, new DateTime(2017, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "Model", "Price", "PurchaseDate" },
                values: new object[,]
                {
                    { 1, "Samsung", 3500m, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Iphone", 6000m, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Android", 2500m, new DateTime(2018, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropTable(
                name: "Phones");
        }
    }
}
