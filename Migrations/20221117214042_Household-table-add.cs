using Microsoft.EntityFrameworkCore.Migrations;

namespace Dashboard.Migrations
{
    public partial class Householdtableadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Households",
                columns: table => new
                {
                    Hshd_num = table.Column<int>(nullable: false),
                    Loyalty_flag = table.Column<string>(maxLength: 1, nullable: true),
                    Age_range = table.Column<string>(nullable: true),
                    Marital_status = table.Column<string>(nullable: true),
                    Income_range = table.Column<string>(nullable: true),
                    Homeower_desc = table.Column<string>(nullable: true),
                    Hshd_composition = table.Column<string>(nullable: true),
                    Hshd_size = table.Column<string>(nullable: true),
                    children = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Households", x => x.Hshd_num);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Households");
        }
    }
}
