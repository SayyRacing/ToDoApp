using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoApp.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ExpiryDate", "Name" },
                values: new object[] { 1, new DateTime(2024, 1, 25, 11, 38, 27, 187, DateTimeKind.Local), "Get AWS Certified" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ExpiryDate", "Name" },
                values: new object[] { 2, new DateTime(2023, 11, 8, 11, 38, 27, 187, DateTimeKind.Local).AddTicks(50), "Book off days" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ExpiryDate", "Name" },
                values: new object[] { 3, new DateTime(2023, 11, 7, 11, 38, 27, 187, DateTimeKind.Local).AddTicks(50), "Read a book" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ExpiryDate", "Name" },
                values: new object[] { 4, new DateTime(2023, 11, 17, 11, 38, 27, 187, DateTimeKind.Local).AddTicks(50), "Pay Electricity bill" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ExpiryDate", "Name" },
                values: new object[] { 5, new DateTime(2023, 10, 28, 11, 38, 27, 187, DateTimeKind.Local).AddTicks(60), "Get Groceries" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
