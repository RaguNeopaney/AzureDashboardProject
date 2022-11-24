using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dashboard.Migrations
{
    public partial class addedproductandtransactionstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_num = table.Column<int>(nullable: false),
                    Department = table.Column<string>(nullable: true),
                    Commodity = table.Column<string>(nullable: true),
                    Brand_type = table.Column<string>(nullable: true),
                    Natural_organic_flag = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_num);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Basket_num = table.Column<int>(nullable: false),
                    Purchase_date = table.Column<DateTime>(nullable: false),
                    Spend = table.Column<float>(nullable: false),
                    Units = table.Column<int>(nullable: false),
                    Store_region = table.Column<string>(nullable: true),
                    Week_num = table.Column<int>(nullable: false),
                    Year = table.Column<string>(nullable: true),
                    Product_num = table.Column<int>(nullable: false),
                    Hshd_num = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Transactions_Households_Hshd_num",
                        column: x => x.Hshd_num,
                        principalTable: "Households",
                        principalColumn: "Hshd_num",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Products_Product_num",
                        column: x => x.Product_num,
                        principalTable: "Products",
                        principalColumn: "Product_num",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Hshd_num",
                table: "Transactions",
                column: "Hshd_num");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Product_num",
                table: "Transactions",
                column: "Product_num");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
