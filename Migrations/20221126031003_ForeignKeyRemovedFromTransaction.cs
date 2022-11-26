using Microsoft.EntityFrameworkCore.Migrations;

namespace Dashboard.Migrations
{
    public partial class ForeignKeyRemovedFromTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Households_Hshd_num",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Products_Product_num",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_Hshd_num",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_Product_num",
                table: "Transactions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Hshd_num",
                table: "Transactions",
                column: "Hshd_num");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Product_num",
                table: "Transactions",
                column: "Product_num");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Households_Hshd_num",
                table: "Transactions",
                column: "Hshd_num",
                principalTable: "Households",
                principalColumn: "Hshd_num",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Products_Product_num",
                table: "Transactions",
                column: "Product_num",
                principalTable: "Products",
                principalColumn: "Product_num",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
