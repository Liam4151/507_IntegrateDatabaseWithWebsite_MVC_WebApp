using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TypicalTools.Migrations
{
    public partial class Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminUsers",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminUsers", x => x.AdminId);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2023, 4, 7, 20, 14, 3, 567, DateTimeKind.Local).AddTicks(886));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminUsers");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 1,
                column: "UpdateDate",
                value: new DateTime(2023, 4, 7, 16, 36, 0, 492, DateTimeKind.Local).AddTicks(4514));
        }
    }
}
