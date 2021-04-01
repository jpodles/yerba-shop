using Microsoft.EntityFrameworkCore.Migrations;

namespace YerbaShop.API.Migrations
{
    public partial class ProductLinkFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ProductImage",
                value: "https://www.poyerbani.pl/pol_pl_Verde-Mate-Green-Mas-IQ-0-5kg-4240_1.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ProductImage",
                value: "https://www.poyerbani.pl/product-pol-4240-Verde-Mate-Green-Mas-IQ-0-5kg.html");
        }
    }
}
