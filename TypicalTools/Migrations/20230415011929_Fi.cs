using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TypicalTools.Migrations
{
    public partial class Fi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "AdminUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2023, 4, 15, 11, 19, 29, 182, DateTimeKind.Local).AddTicks(4153));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "AdminUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2023, 4, 8, 18, 16, 38, 72, DateTimeKind.Local).AddTicks(5872));
        }
    }
}
