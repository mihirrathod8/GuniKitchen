using Microsoft.EntityFrameworkCore.Migrations;

namespace GuniKitchen.Data.Migrations
{
    public partial class x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Product_Size",
                table: "Products",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Product_Size",
                table: "Products",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);
        }
    }
}
