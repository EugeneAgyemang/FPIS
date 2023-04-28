using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIDToReceivedStockModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "ReceivedStocks",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ReceivedStocks_UserId",
                table: "ReceivedStocks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceivedStocks_Users_UserId",
                table: "ReceivedStocks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceivedStocks_Users_UserId",
                table: "ReceivedStocks");

            migrationBuilder.DropIndex(
                name: "IX_ReceivedStocks_UserId",
                table: "ReceivedStocks");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ReceivedStocks");
        }
    }
}
