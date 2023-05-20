using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class AddMinimumParameterValueColumnsToProductAndWaterParameterTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "MinimumControlLimit",
                table: "WaterParameters",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "MinimumSpecification",
                table: "ProductParameters",
                type: "real",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinimumControlLimit",
                table: "WaterParameters");

            migrationBuilder.DropColumn(
                name: "MinimumSpecification",
                table: "ProductParameters");
        }
    }
}
