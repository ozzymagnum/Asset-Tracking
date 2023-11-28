using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp3.Migrations
{
    /// <inheritdoc />
    public partial class SeddingNewPhonesDAta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "Model", "Price", "PurchaseDate" },
                values: new object[] { 4, "Iphone", 6000m, new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
