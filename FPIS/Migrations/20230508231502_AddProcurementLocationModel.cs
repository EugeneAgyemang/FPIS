using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class AddProcurementLocationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcurementLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    Lot = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ReceivingId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcurementLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcurementLocations_Receivings_ReceivingId",
                        column: x => x.ReceivingId,
                        principalTable: "Receivings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProcurementLocations_ReceivingId",
                table: "ProcurementLocations",
                column: "ReceivingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcurementLocations");
        }
    }
}
