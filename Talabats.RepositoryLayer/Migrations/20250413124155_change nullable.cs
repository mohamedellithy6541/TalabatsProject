using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Talabats.RepositoryLayer.Migrations
{
    public partial class changenullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_productBrands_productBrandId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_productTypes_productTypeId",
                table: "products");

            migrationBuilder.AlterColumn<int>(
                name: "productTypeId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "productBrandId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_products_productBrands_productBrandId",
                table: "products",
                column: "productBrandId",
                principalTable: "productBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_productTypes_productTypeId",
                table: "products",
                column: "productTypeId",
                principalTable: "productTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_productBrands_productBrandId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_productTypes_productTypeId",
                table: "products");

            migrationBuilder.AlterColumn<int>(
                name: "productTypeId",
                table: "products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "productBrandId",
                table: "products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_products_productBrands_productBrandId",
                table: "products",
                column: "productBrandId",
                principalTable: "productBrands",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_productTypes_productTypeId",
                table: "products",
                column: "productTypeId",
                principalTable: "productTypes",
                principalColumn: "Id");
        }
    }
}
