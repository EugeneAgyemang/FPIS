using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLocationAndLotFieldsFromMaterialProcurementModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "MaterialProcurements");

            migrationBuilder.DropColumn(
                name: "Lot",
                table: "MaterialProcurements");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "MaterialProcurements",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lot",
                table: "MaterialProcurements",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
