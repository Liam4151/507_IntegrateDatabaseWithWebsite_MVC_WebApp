using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TypicalTools.Migrations
{
    public partial class newefcore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2023, 4, 8, 18, 16, 38, 72, DateTimeKind.Local).AddTicks(5872));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2023, 4, 8, 18, 15, 34, 739, DateTimeKind.Local).AddTicks(541));
        }
    }
}
