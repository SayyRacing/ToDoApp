using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoApp.Migrations
{
    public partial class NamingFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ExpiryDate", "Name" },
                values: new object[] { 1, new DateTime(2024, 1, 25, 14, 11, 32, 713, DateTimeKind.Local).AddTicks(9980), "Get AWS Certified" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ExpiryDate", "Name" },
                values: new object[] { 2, new DateTime(2023, 11, 8, 14, 11, 32, 714, DateTimeKind.Local).AddTicks(20), "Book off days" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ExpiryDate", "Name" },
                values: new object[] { 3, new DateTime(2023, 11, 7, 14, 11, 32, 714, DateTimeKind.Local).AddTicks(30), "Read a book" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ExpiryDate", "Name" },
                values: new object[] { 4, new DateTime(2023, 11, 17, 14, 11, 32, 714, DateTimeKind.Local).AddTicks(30), "Pay Electricity bill" });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "ExpiryDate", "Name" },
                values: new object[] { 5, new DateTime(2023, 10, 28, 14, 11, 32, 714, DateTimeKind.Local).AddTicks(30), "Get Groceries" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

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
    }
}
