using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class LetValueColumnInSampleResultsDetailWithParameterAcceptNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Value",
                table: "SampleResultsDetailsWithParameters",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<bool>(
                name: "IsRejected",
                table: "SampleResultDetails",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "SampleResultDetails",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "SampleDetails",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRejected",
                table: "SampleResultDetails");

            migrationBuilder.DropColumn(
                name: "Label",
                table: "SampleResultDetails");

            migrationBuilder.DropColumn(
                name: "Label",
                table: "SampleDetails");

            migrationBuilder.AlterColumn<float>(
                name: "Value",
                table: "SampleResultsDetailsWithParameters",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }
    }
}
