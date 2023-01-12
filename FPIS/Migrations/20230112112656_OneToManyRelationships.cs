using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnalysisItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemType = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisParameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DesignationName = table.Column<string>(type: "text", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Designations_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IssuedStocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    QuantityIssued = table.Column<int>(type: "integer", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    StockItemId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuedStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IssuedStocks_StockItems_StockItemId",
                        column: x => x.StockItemId,
                        principalTable: "StockItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceivedStocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ReceivedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    QuantityAvailable = table.Column<int>(type: "integer", nullable: false),
                    ExpiryDate = table.Column<DateOnly>(type: "date", nullable: false),
                    StockItemId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivedStocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceivedStocks_StockItems_StockItemId",
                        column: x => x.StockItemId,
                        principalTable: "StockItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    AnalysisItemId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnalysisProducts_AnalysisItems_AnalysisItemId",
                        column: x => x.AnalysisItemId,
                        principalTable: "AnalysisItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnalysisProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnalysisWaters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    WaterId = table.Column<Guid>(type: "uuid", nullable: false),
                    AnalysisItemId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalysisWaters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnalysisWaters_AnalysisItems_AnalysisItemId",
                        column: x => x.AnalysisItemId,
                        principalTable: "AnalysisItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnalysisWaters_Waters_WaterId",
                        column: x => x.WaterId,
                        principalTable: "Waters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAnalysisParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductParameterId = table.Column<Guid>(type: "uuid", nullable: false),
                    AnalysisParameterId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAnalysisParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAnalysisParameters_AnalysisParameters_AnalysisParame~",
                        column: x => x.AnalysisParameterId,
                        principalTable: "AnalysisParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAnalysisParameters_ProductParameters_ProductParamete~",
                        column: x => x.ProductParameterId,
                        principalTable: "ProductParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterAnalysisParameters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    WaterParameterId = table.Column<Guid>(type: "uuid", nullable: false),
                    AnalysisParameterId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterAnalysisParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterAnalysisParameters_AnalysisParameters_AnalysisParamete~",
                        column: x => x.AnalysisParameterId,
                        principalTable: "AnalysisParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WaterAnalysisParameters_WaterParameters_WaterParameterId",
                        column: x => x.WaterParameterId,
                        principalTable: "WaterParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EmpID = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    MiddleName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    DesignationId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialProcurements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    Remarks = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialProcurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaterialProcurements_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialProcurements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionDailyReports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TimeIn = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    TimeOut = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    ProductionRemark = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionDailyReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionDailyReports_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Samples",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false),
                    TypeForFiltering = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Employee1 = table.Column<string>(type: "text", nullable: false),
                    Employee2 = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Samples_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receivings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Supplier = table.Column<string>(type: "text", nullable: false),
                    TruckNumber = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Units = table.Column<string>(type: "text", nullable: false),
                    MaterialProcurementId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receivings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receivings_MaterialProcurements_MaterialProcurementId",
                        column: x => x.MaterialProcurementId,
                        principalTable: "MaterialProcurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Releasings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FatContent = table.Column<int>(type: "integer", nullable: false),
                    MaterialProcurementId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Releasings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Releasings_MaterialProcurements_MaterialProcurementId",
                        column: x => x.MaterialProcurementId,
                        principalTable: "MaterialProcurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SampleResults",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    IsRetest = table.Column<bool>(type: "boolean", nullable: false),
                    SampleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SampleResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SampleResults_Samples_SampleId",
                        column: x => x.SampleId,
                        principalTable: "Samples",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinishedProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Consignee = table.Column<string>(type: "text", nullable: false),
                    ProductType = table.Column<string>(type: "text", nullable: false),
                    BatchNumber = table.Column<string>(type: "text", nullable: false),
                    ContainerNumber = table.Column<string>(type: "text", nullable: false),
                    SealNumber = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<string>(type: "text", nullable: false),
                    SampleResultId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinishedProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinishedProducts_SampleResults_SampleResultId",
                        column: x => x.SampleResultId,
                        principalTable: "SampleResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisProducts_AnalysisItemId",
                table: "AnalysisProducts",
                column: "AnalysisItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisProducts_ProductId",
                table: "AnalysisProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisWaters_AnalysisItemId",
                table: "AnalysisWaters",
                column: "AnalysisItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalysisWaters_WaterId",
                table: "AnalysisWaters",
                column: "WaterId");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_DepartmentId",
                table: "Designations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_FinishedProducts_SampleResultId",
                table: "FinishedProducts",
                column: "SampleResultId");

            migrationBuilder.CreateIndex(
                name: "IX_IssuedStocks_StockItemId",
                table: "IssuedStocks",
                column: "StockItemId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialProcurements_ProductId",
                table: "MaterialProcurements",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialProcurements_UserId",
                table: "MaterialProcurements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAnalysisParameters_AnalysisParameterId",
                table: "ProductAnalysisParameters",
                column: "AnalysisParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAnalysisParameters_ProductParameterId",
                table: "ProductAnalysisParameters",
                column: "ProductParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionDailyReports_UserId",
                table: "ProductionDailyReports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceivedStocks_StockItemId",
                table: "ReceivedStocks",
                column: "StockItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivings_MaterialProcurementId",
                table: "Receivings",
                column: "MaterialProcurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Releasings_MaterialProcurementId",
                table: "Releasings",
                column: "MaterialProcurementId");

            migrationBuilder.CreateIndex(
                name: "IX_SampleResults_SampleId",
                table: "SampleResults",
                column: "SampleId");

            migrationBuilder.CreateIndex(
                name: "IX_Samples_UserId",
                table: "Samples",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DesignationId",
                table: "Users",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterAnalysisParameters_AnalysisParameterId",
                table: "WaterAnalysisParameters",
                column: "AnalysisParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterAnalysisParameters_WaterParameterId",
                table: "WaterAnalysisParameters",
                column: "WaterParameterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalysisProducts");

            migrationBuilder.DropTable(
                name: "AnalysisWaters");

            migrationBuilder.DropTable(
                name: "FinishedProducts");

            migrationBuilder.DropTable(
                name: "IssuedStocks");

            migrationBuilder.DropTable(
                name: "ProductAnalysisParameters");

            migrationBuilder.DropTable(
                name: "ProductionDailyReports");

            migrationBuilder.DropTable(
                name: "ReceivedStocks");

            migrationBuilder.DropTable(
                name: "Receivings");

            migrationBuilder.DropTable(
                name: "Releasings");

            migrationBuilder.DropTable(
                name: "WaterAnalysisParameters");

            migrationBuilder.DropTable(
                name: "AnalysisItems");

            migrationBuilder.DropTable(
                name: "SampleResults");

            migrationBuilder.DropTable(
                name: "MaterialProcurements");

            migrationBuilder.DropTable(
                name: "AnalysisParameters");

            migrationBuilder.DropTable(
                name: "Samples");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Designations");
        }
    }
}
