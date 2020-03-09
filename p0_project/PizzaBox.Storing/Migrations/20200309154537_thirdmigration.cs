using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderPizza_orders_PizzaId",
                table: "OrderPizza");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaTopping_toppings_ToppingId",
                table: "PizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_toppings",
                table: "toppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

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

            migrationBuilder.RenameTable(
                name: "toppings",
                newName: "Toppings");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Orders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings",
                column: "ToppingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.InsertData(
                table: "Crusts",
                columns: new[] { "CrustId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193475374744570L, "Deep Dish", 4.00m },
                    { 637193475374744989L, "New york style", 3.00m },
                    { 637193475374745007L, "Thin Crust", 1.50m }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193475374704430L, "Large", 12.0m },
                    { 637193475374732645L, "Medium", 10.0m },
                    { 637193475374732698L, "Small", 8.00m }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "ToppingId", "Name", "Price" },
                values: new object[,]
                {
                    { 637193475374745768L, "Cheese", 0.25m },
                    { 637193475374746087L, "Pepperoni", 0.50m },
                    { 637193475374746109L, "Tomato Sauce", 0.75m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPizza_Orders_PizzaId",
                table: "OrderPizza",
                column: "PizzaId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaTopping_Toppings_ToppingId",
                table: "PizzaTopping",
                column: "ToppingId",
                principalTable: "Toppings",
                principalColumn: "ToppingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderPizza_Orders_PizzaId",
                table: "OrderPizza");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaTopping_Toppings_ToppingId",
                table: "PizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193475374744570L);

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193475374744989L);

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "CrustId",
                keyValue: 637193475374745007L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193475374704430L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193475374732645L);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 637193475374732698L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 637193475374745768L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 637193475374746087L);

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "ToppingId",
                keyValue: 637193475374746109L);

            migrationBuilder.RenameTable(
                name: "Toppings",
                newName: "toppings");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_toppings",
                table: "toppings",
                column: "ToppingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "OrderId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPizza_orders_PizzaId",
                table: "OrderPizza",
                column: "PizzaId",
                principalTable: "orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaTopping_toppings_ToppingId",
                table: "PizzaTopping",
                column: "ToppingId",
                principalTable: "toppings",
                principalColumn: "ToppingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
