using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectFlowerShop.Migrations
{
    public partial class NullabeFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Discounts_DiscountId",
                table: "ShoppingCarts");

            migrationBuilder.AlterColumn<int>(
                name: "DiscountId",
                table: "ShoppingCarts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Discounts_DiscountId",
                table: "ShoppingCarts",
                column: "DiscountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Discounts_DiscountId",
                table: "ShoppingCarts");

            migrationBuilder.AlterColumn<int>(
                name: "DiscountId",
                table: "ShoppingCarts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Discounts_DiscountId",
                table: "ShoppingCarts",
                column: "DiscountId",
                principalTable: "Discounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
