using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopCar.Migrations
{
    public partial class Shopcart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shopCartItems_Car_carid",
                table: "shopCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_shopCartItems",
                table: "shopCartItems");

            migrationBuilder.RenameTable(
                name: "shopCartItems",
                newName: "ShopCartItem");

            migrationBuilder.RenameIndex(
                name: "IX_shopCartItems_carid",
                table: "ShopCartItem",
                newName: "IX_ShopCartItem_carid");

            migrationBuilder.AlterColumn<string>(
                name: "ShopCartId",
                table: "ShopCartItem",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopCartItem",
                table: "ShopCartItem",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItem_Car_carid",
                table: "ShopCartItem",
                column: "carid",
                principalTable: "Car",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItem_Car_carid",
                table: "ShopCartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopCartItem",
                table: "ShopCartItem");

            migrationBuilder.RenameTable(
                name: "ShopCartItem",
                newName: "shopCartItems");

            migrationBuilder.RenameIndex(
                name: "IX_ShopCartItem_carid",
                table: "shopCartItems",
                newName: "IX_shopCartItems_carid");

            migrationBuilder.AlterColumn<int>(
                name: "ShopCartId",
                table: "shopCartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_shopCartItems",
                table: "shopCartItems",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_shopCartItems_Car_carid",
                table: "shopCartItems",
                column: "carid",
                principalTable: "Car",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
