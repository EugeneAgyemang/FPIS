using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class ChangeControlLimitDataTypeOfWaterParameterToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ControlLimit",
                table: "WaterParameters",
                type: "text",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "ControlLimit",
                table: "WaterParameters",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
