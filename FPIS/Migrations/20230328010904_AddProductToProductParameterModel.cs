using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class AddProductToProductParameterModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "ProductParameters",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("85c8f1e5-f64e-4632-84df-e949b54ad47d"));

            migrationBuilder.CreateIndex(
                name: "IX_ProductParameters_ProductId",
                table: "ProductParameters",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductParameters_Products_ProductId",
                table: "ProductParameters",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductParameters_Products_ProductId",
                table: "ProductParameters");

            migrationBuilder.DropIndex(
                name: "IX_ProductParameters_ProductId",
                table: "ProductParameters");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductParameters");
        }
    }
}
