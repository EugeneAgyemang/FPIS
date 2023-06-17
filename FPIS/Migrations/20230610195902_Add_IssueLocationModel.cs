using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class AddIssueLocationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IssueLocations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ApproxWeight = table.Column<string>(type: "text", nullable: false),
                    ProcurementLocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    ReleasingId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IssueLocations_ProcurementLocations_ProcurementLocationId",
                        column: x => x.ProcurementLocationId,
                        principalTable: "ProcurementLocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IssueLocations_Releasings_ReleasingId",
                        column: x => x.ReleasingId,
                        principalTable: "Releasings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IssueLocations_ProcurementLocationId",
                table: "IssueLocations",
                column: "ProcurementLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_IssueLocations_ReleasingId",
                table: "IssueLocations",
                column: "ReleasingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssueLocations");
        }
    }
}
