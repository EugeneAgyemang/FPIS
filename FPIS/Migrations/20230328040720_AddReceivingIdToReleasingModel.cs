using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class AddReceivingIdToReleasingModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ReceivingId",
                table: "Releasings",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Releasings_ReceivingId",
                table: "Releasings",
                column: "ReceivingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Releasings_Receivings_ReceivingId",
                table: "Releasings",
                column: "ReceivingId",
                principalTable: "Receivings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Releasings_Receivings_ReceivingId",
                table: "Releasings");

            migrationBuilder.DropIndex(
                name: "IX_Releasings_ReceivingId",
                table: "Releasings");

            migrationBuilder.DropColumn(
                name: "ReceivingId",
                table: "Releasings");
        }
    }
}
