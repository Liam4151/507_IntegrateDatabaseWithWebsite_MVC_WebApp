using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TypicalTools.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Products",
                newName: "UpdatedDate");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2023, 4, 8, 18, 15, 34, 739, DateTimeKind.Local).AddTicks(541));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Products",
                newName: "UpdateDate");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2023, 4, 8, 12, 37, 2, 141, DateTimeKind.Local).AddTicks(6407));
        }
    }
}
