using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class AddWaterFieldToWaterParameterModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "WaterId",
                table: "WaterParameters",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("9820560a-947d-44ba-9fba-f418abcb545b"));

            migrationBuilder.CreateIndex(
                name: "IX_WaterParameters_WaterId",
                table: "WaterParameters",
                column: "WaterId");

            migrationBuilder.AddForeignKey(
                name: "FK_WaterParameters_Waters_WaterId",
                table: "WaterParameters",
                column: "WaterId",
                principalTable: "Waters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WaterParameters_Waters_WaterId",
                table: "WaterParameters");

            migrationBuilder.DropIndex(
                name: "IX_WaterParameters_WaterId",
                table: "WaterParameters");

            migrationBuilder.DropColumn(
                name: "WaterId",
                table: "WaterParameters");
        }
    }
}
