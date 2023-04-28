using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSampleResultModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SampleResultDetails_Users_UserId",
                table: "SampleResultDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SampleResultsDetailsWithParameters_SampleDetails_SampleDeta~",
                table: "SampleResultsDetailsWithParameters");

            migrationBuilder.DropIndex(
                name: "IX_SampleResultsDetailsWithParameters_SampleDetailId",
                table: "SampleResultsDetailsWithParameters");

            migrationBuilder.DropColumn(
                name: "SampleDetailId",
                table: "SampleResultsDetailsWithParameters");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "SampleResultDetails",
                newName: "AnalysisItemId");

            migrationBuilder.RenameIndex(
                name: "IX_SampleResultDetails_UserId",
                table: "SampleResultDetails",
                newName: "IX_SampleResultDetails_AnalysisItemId");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "SampleResults",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_SampleResults_UserId",
                table: "SampleResults",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SampleResultDetails_AnalysisItems_AnalysisItemId",
                table: "SampleResultDetails",
                column: "AnalysisItemId",
                principalTable: "AnalysisItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SampleResults_Users_UserId",
                table: "SampleResults",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SampleResultDetails_AnalysisItems_AnalysisItemId",
                table: "SampleResultDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SampleResults_Users_UserId",
                table: "SampleResults");

            migrationBuilder.DropIndex(
                name: "IX_SampleResults_UserId",
                table: "SampleResults");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SampleResults");

            migrationBuilder.RenameColumn(
                name: "AnalysisItemId",
                table: "SampleResultDetails",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_SampleResultDetails_AnalysisItemId",
                table: "SampleResultDetails",
                newName: "IX_SampleResultDetails_UserId");

            migrationBuilder.AddColumn<Guid>(
                name: "SampleDetailId",
                table: "SampleResultsDetailsWithParameters",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_SampleResultsDetailsWithParameters_SampleDetailId",
                table: "SampleResultsDetailsWithParameters",
                column: "SampleDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_SampleResultDetails_Users_UserId",
                table: "SampleResultDetails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SampleResultsDetailsWithParameters_SampleDetails_SampleDeta~",
                table: "SampleResultsDetailsWithParameters",
                column: "SampleDetailId",
                principalTable: "SampleDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
