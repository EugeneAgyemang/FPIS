using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcurementAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    ProcurementId = table.Column<Guid>(type: "uuid", nullable: false),
                    MaterialAttributeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcurementAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcurementAttributes_MaterialAttributes_MaterialAttributeId",
                        column: x => x.MaterialAttributeId,
                        principalTable: "MaterialAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcurementAttributes_MaterialProcurements_ProcurementId",
                        column: x => x.ProcurementId,
                        principalTable: "MaterialProcurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcurementParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    ProcurementId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductParameterId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcurementParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcurementParameters_MaterialProcurements_ProcurementId",
                        column: x => x.ProcurementId,
                        principalTable: "MaterialProcurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProcurementParameters_ProductParameters_ProductParameterId",
                        column: x => x.ProductParameterId,
                        principalTable: "ProductParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SampleDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SampleId = table.Column<Guid>(type: "uuid", nullable: false),
                    AnalysisItemId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleDetails_AnalysisItems_AnalysisItemId",
                        column: x => x.AnalysisItemId,
                        principalTable: "AnalysisItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SampleDetails_Samples_SampleId",
                        column: x => x.SampleId,
                        principalTable: "Samples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SampleResultDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SampleResultId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleResultDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleResultDetails_SampleResults_SampleResultId",
                        column: x => x.SampleResultId,
                        principalTable: "SampleResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SampleResultDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisRemarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Remark = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SampleDetailId = table.Column<Guid>(type: "uuid", nullable: false),
                    SampleResultDetailId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisRemarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnalysisRemarks_SampleDetails_SampleDetailId",
                        column: x => x.SampleDetailId,
                        principalTable: "SampleDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnalysisRemarks_SampleResultDetails_SampleResultDetailId",
                        column: x => x.SampleResultDetailId,
                        principalTable: "SampleResultDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnalysisRemarks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SampleResultsDetailsWithParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false),
                    SampleResultDetailId = table.Column<Guid>(type: "uuid", nullable: false),
                    SampleDetailId = table.Column<Guid>(type: "uuid", nullable: false),
                    AnalysisParameterId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleResultsDetailsWithParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleResultsDetailsWithParameters_AnalysisParameters_Analy~",
                        column: x => x.AnalysisParameterId,
                        principalTable: "AnalysisParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SampleResultsDetailsWithParameters_SampleDetails_SampleDeta~",
                        column: x => x.SampleDetailId,
                        principalTable: "SampleDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SampleResultsDetailsWithParameters_SampleResultDetails_Samp~",
                        column: x => x.SampleResultDetailId,
                        principalTable: "SampleResultDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisRemarks_SampleDetailId",
                table: "AnalysisRemarks",
                column: "SampleDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisRemarks_SampleResultDetailId",
                table: "AnalysisRemarks",
                column: "SampleResultDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisRemarks_UserId",
                table: "AnalysisRemarks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcurementAttributes_MaterialAttributeId",
                table: "ProcurementAttributes",
                column: "MaterialAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcurementAttributes_ProcurementId",
                table: "ProcurementAttributes",
                column: "ProcurementId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcurementParameters_ProcurementId",
                table: "ProcurementParameters",
                column: "ProcurementId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcurementParameters_ProductParameterId",
                table: "ProcurementParameters",
                column: "ProductParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleDetails_AnalysisItemId",
                table: "SampleDetails",
                column: "AnalysisItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleDetails_SampleId",
                table: "SampleDetails",
                column: "SampleId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleResultDetails_SampleResultId",
                table: "SampleResultDetails",
                column: "SampleResultId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleResultDetails_UserId",
                table: "SampleResultDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleResultsDetailsWithParameters_AnalysisParameterId",
                table: "SampleResultsDetailsWithParameters",
                column: "AnalysisParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleResultsDetailsWithParameters_SampleDetailId",
                table: "SampleResultsDetailsWithParameters",
                column: "SampleDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleResultsDetailsWithParameters_SampleResultDetailId",
                table: "SampleResultsDetailsWithParameters",
                column: "SampleResultDetailId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalysisRemarks");

            migrationBuilder.DropTable(
                name: "ProcurementAttributes");

            migrationBuilder.DropTable(
                name: "ProcurementParameters");

            migrationBuilder.DropTable(
                name: "SampleResultsDetailsWithParameters");

            migrationBuilder.DropTable(
                name: "SampleDetails");

            migrationBuilder.DropTable(
                name: "SampleResultDetails");
        }
    }
}
