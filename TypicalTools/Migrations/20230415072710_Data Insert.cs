using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TypicalTools.Migrations
{
    public partial class DataInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "ProductDescription", "ProductName", "ProductPrice", "UpdatedDate" },
                values: new object[,]
                {
                    { 12345, "bluetooth headphones with fair battery life and a 1 month warranty", "Generic Headphones", 84.99m, new DateTime(2023, 4, 15, 17, 27, 9, 888, DateTimeKind.Local).AddTicks(1144) },
                    { 12346, "bluetooth headphones with good battery life and a 6 month warranty", "Expensive Headphones", 149.99m, new DateTime(2023, 4, 15, 17, 27, 9, 888, DateTimeKind.Local).AddTicks(1147) },
                    { 12347, "bluetooth headphones with good battery life and a 12 month warranty", "Name Brand Headphones", 199.99m, new DateTime(2023, 4, 15, 17, 27, 9, 888, DateTimeKind.Local).AddTicks(1149) },
                    { 12348, "simple bluetooth pointing device", "Generic Wireless Mouse", 39.99m, new DateTime(2023, 4, 15, 17, 27, 9, 888, DateTimeKind.Local).AddTicks(1151) },
                    { 12349, "mouse and keyboard wired combination", "Logitach Mouse and Keyboard", 73.99m, new DateTime(2023, 4, 15, 17, 27, 9, 888, DateTimeKind.Local).AddTicks(1152) },
                    { 12350, "quality wireless mouse", "Logitach Wireless Mouse", 149.99m, new DateTime(2023, 4, 15, 17, 27, 9, 888, DateTimeKind.Local).AddTicks(1154) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 12345);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 12346);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 12347);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 12348);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 12349);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductCode",
                keyValue: 12350);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductCode", "ProductDescription", "ProductName", "ProductPrice", "UpdatedDate" },
                values: new object[] { 1, "Test", "Test", 1m, new DateTime(2023, 4, 15, 11, 19, 29, 182, DateTimeKind.Local).AddTicks(4153) });
        }
    }
}
