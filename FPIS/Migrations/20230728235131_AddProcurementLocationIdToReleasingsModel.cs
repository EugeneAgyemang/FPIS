using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class AddProcurementLocationIdToReleasingsModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProcurementLocationId",
                table: "Releasings",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Releasings_ProcurementLocations_ProcurementLocationId",
                table: "Releasings",
                column: "ProcurementLocationId",
                principalTable: "ProcurementLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Releasings_ProcurementLocations_ProcurementLocationId",
                table: "Releasings");

            migrationBuilder.DropIndex(
                name: "IX_Releasings_ProcurementLocationId",
                table: "Releasings");

            migrationBuilder.DropColumn(
                name: "ProcurementLocationId",
                table: "Releasings");
        }
    }
}
