﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FPIS.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIDToIssuedStockModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "IssuedStocks",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_IssuedStocks_UserId",
                table: "IssuedStocks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_IssuedStocks_Users_UserId",
                table: "IssuedStocks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IssuedStocks_Users_UserId",
                table: "IssuedStocks");

            migrationBuilder.DropIndex(
                name: "IX_IssuedStocks_UserId",
                table: "IssuedStocks");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "IssuedStocks");
        }
    }
}