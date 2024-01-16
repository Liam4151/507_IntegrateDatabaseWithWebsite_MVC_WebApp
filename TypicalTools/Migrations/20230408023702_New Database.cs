using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TypicalTools.Migrations
{
    public partial class NewDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2023, 4, 8, 12, 37, 2, 141, DateTimeKind.Local).AddTicks(6407));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2023, 4, 7, 20, 14, 3, 567, DateTimeKind.Local).AddTicks(886));
        }
    }
}
