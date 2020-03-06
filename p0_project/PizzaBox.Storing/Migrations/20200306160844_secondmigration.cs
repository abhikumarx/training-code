using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    PizzaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CrustId = table.Column<long>(nullable: true),
                    SizeId = table.Column<long>(nullable: true),
                    ToppingId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.PizzaId);
                });

            migrationBuilder.CreateTable(
                name: "Crusts",
                columns: table => new
                {
                    CrustId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PizzaId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crusts", x => x.CrustId);
                    table.ForeignKey(
                        name: "FK_Crusts_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "PizzaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PizzaId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeId);
                    table.ForeignKey(
                        name: "FK_Sizes_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "PizzaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "toppings",
                columns: table => new
                {
                    ToppingId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PizzaId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toppings", x => x.ToppingId);
                    table.ForeignKey(
                        name: "FK_toppings_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "PizzaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Crusts",
                columns: new[] { "CrustId", "Name", "PizzaId", "Price" },
                values: new object[,]
                {
                    { 637190861237333692L, "Deep Dish", null, 4.00m },
                    { 637190861237334105L, "New york style", null, 3.00m },
                    { 637190861237334123L, "Thin Crust", null, 1.50m }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "Name", "PizzaId", "Price" },
                values: new object[,]
                {
                    { 637190861237283095L, "Large", null, 12.0m },
                    { 637190861237320160L, "Medium", null, 10.0m },
                    { 637190861237320223L, "Small", null, 8.00m }
                });

            migrationBuilder.InsertData(
                table: "toppings",
                columns: new[] { "ToppingId", "Name", "PizzaId", "Price" },
                values: new object[,]
                {
                    { 637190861237334962L, "Cheese", null, 0.25m },
                    { 637190861237335328L, "Pepperoni", null, 0.50m },
                    { 637190861237335359L, "Tomato Sauce", null, 0.75m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crusts_PizzaId",
                table: "Crusts",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CrustId",
                table: "Pizzas",
                column: "CrustId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeId",
                table: "Pizzas",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_ToppingId",
                table: "Pizzas",
                column: "ToppingId");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_PizzaId",
                table: "Sizes",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_toppings_PizzaId",
                table: "toppings",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Crusts_CrustId",
                table: "Pizzas",
                column: "CrustId",
                principalTable: "Crusts",
                principalColumn: "CrustId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Sizes_SizeId",
                table: "Pizzas",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_toppings_ToppingId",
                table: "Pizzas",
                column: "ToppingId",
                principalTable: "toppings",
                principalColumn: "ToppingId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crusts_Pizzas_PizzaId",
                table: "Crusts");

            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_Pizzas_PizzaId",
                table: "Sizes");

            migrationBuilder.DropForeignKey(
                name: "FK_toppings_Pizzas_PizzaId",
                table: "toppings");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Crusts");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "toppings");
        }
    }
}
