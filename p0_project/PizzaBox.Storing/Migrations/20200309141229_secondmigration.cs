using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193063487026650L);

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193063487027032L);

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193063487027051L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193063486980346L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193063487014662L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193063487014720L);

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "ToppingId",
                keyValue: 637193063487027799L);

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "ToppingId",
                keyValue: 637193063487028129L);

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "ToppingId",
                keyValue: 637193063487028155L);

            migrationBuilder.InsertData(
                table: "Crusts",
                columns: new[] { "CrustId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193419495008097L, "Deep Dish", 4.00m },
                    { 637193419495008472L, "New york style", 3.00m },
                    { 637193419495008491L, "Thin Crust", 1.50m }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193419494969114L, "Large", 12.0m },
                    { 637193419494997281L, "Medium", 10.0m },
                    { 637193419494997336L, "Small", 8.00m }
                });

            migrationBuilder.InsertData(
                table: "toppings",
                columns: new[] { "ToppingId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193419495009415L, "Cheese", 0.25m },
                    { 637193419495009818L, "Pepperoni", 0.50m },
                    { 637193419495009845L, "Tomato Sauce", 0.75m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193419495008097L);

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193419495008472L);

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193419495008491L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193419494969114L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193419494997281L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193419494997336L);

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "ToppingId",
                keyValue: 637193419495009415L);

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "ToppingId",
                keyValue: 637193419495009818L);

            migrationBuilder.DeleteData(
                table: "toppings",
                keyColumn: "ToppingId",
                keyValue: 637193419495009845L);

            migrationBuilder.InsertData(
                table: "Crusts",
                columns: new[] { "CrustId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193063487026650L, "Deep Dish", 4.00m },
                    { 637193063487027032L, "New york style", 3.00m },
                    { 637193063487027051L, "Thin Crust", 1.50m }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193063486980346L, "Large", 12.0m },
                    { 637193063487014662L, "Medium", 10.0m },
                    { 637193063487014720L, "Small", 8.00m }
                });

            migrationBuilder.InsertData(
                table: "toppings",
                columns: new[] { "ToppingId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193063487027799L, "Cheese", 0.25m },
                    { 637193063487028129L, "Pepperoni", 0.50m },
                    { 637193063487028155L, "Tomato Sauce", 0.75m }
                });
        }
    }
}
