using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuniKitchen.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Cart_Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Id = table.Column<short>(type: "smallint", nullable: false),
                    Product_Id = table.Column<short>(type: "smallint", nullable: false),
                    Ordered_Quantity = table.Column<int>(type: "int", nullable: false),
                    Order_Total = table.Column<int>(type: "int", nullable: false),
                    Payment_Type = table.Column<string>(type: "varchar(20)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Status = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ordered_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Cart_Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Product_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Product_Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Size = table.Column<string>(type: "varchar(20)", nullable: false),
                    Product_Category = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
