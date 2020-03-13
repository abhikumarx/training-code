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
                keyValue: 637193683656333338L);

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193683656333712L);

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193683656333810L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193683656292272L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193683656322631L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193683656322686L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 637193683656334548L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 637193683656334942L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 637193683656334966L);

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    StoreId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(nullable: true),
                    StoreAddress = table.Column<string>(nullable: true),
                    PhoneNum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.StoreId);
                });

            migrationBuilder.InsertData(
                table: "Crusts",
                columns: new[] { "CrustId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193768032644120L, "Deep Dish", 4.00m },
                    { 637193768032644362L, "New york style", 3.00m },
                    { 637193768032644378L, "Thin Crust", 1.50m }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193768032621336L, "Large", 12.0m },
                    { 637193768032643447L, "Medium", 10.0m },
                    { 637193768032643491L, "Small", 8.00m }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "ToppingId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193768032645031L, "Cheese", 0.25m },
                    { 637193768032645308L, "Pepperoni", 0.50m },
                    { 637193768032645324L, "Tomato Sauce", 0.75m }
                });

            migrationBuilder.InsertData(
                table: "stores",
                columns: new[] { "StoreId", "PhoneNum", "StoreAddress", "StoreName" },
                values: new object[,]
                {
                    { 1L, "706-855-9963", "1212 home st 76010", "Home Store" },
                    { 2L, "706-996-7841", "5656 Away Avenue 76000", "Away Store" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stores");

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193768032644120L);

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193768032644362L);

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193768032644378L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193768032621336L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193768032643447L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193768032643491L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 637193768032645031L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 637193768032645308L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 637193768032645324L);

            migrationBuilder.InsertData(
                table: "Crusts",
                columns: new[] { "CrustId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193683656333338L, "Deep Dish", 4.00m },
                    { 637193683656333712L, "New york style", 3.00m },
                    { 637193683656333810L, "Thin Crust", 1.50m }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193683656292272L, "Large", 12.0m },
                    { 637193683656322631L, "Medium", 10.0m },
                    { 637193683656322686L, "Small", 8.00m }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "ToppingId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193683656334548L, "Cheese", 0.25m },
                    { 637193683656334942L, "Pepperoni", 0.50m },
                    { 637193683656334966L, "Tomato Sauce", 0.75m }
                });
        }
    }
}
