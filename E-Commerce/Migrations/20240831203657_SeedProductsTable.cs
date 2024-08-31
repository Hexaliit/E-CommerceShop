using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Detail", "ImageUrl", "IsTrending", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "A Fresh coffe to build your day.", "123.png", true, "Coffe", 45000m },
                    { 2, "A Fresh Capochino to build your day.", "123.png", false, "Capochino", 55000m },
                    { 3, "A Fresh Hot chocolate to build your day.", "123.png", false, "Hot Chocolate", 60000m },
                    { 4, "A Fresh Sperco to build your day.", "123.png", true, "Sperco", 50000m },
                    { 5, "A Fresh Ice late to build your day.", "123.png", false, "Ice Late", 40000m },
                    { 6, "A Fresh Americano to build your day.", "123.png", true, "Americano", 70000m },
                    { 7, "A Frapachino to build your day.", "123.png", false, "Frapachino", 80000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
