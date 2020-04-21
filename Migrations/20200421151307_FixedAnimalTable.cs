using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneProject.Migrations
{
    public partial class FixedAnimalTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoodWithOtherAnimals",
                table: "Animals");

            migrationBuilder.AddColumn<string>(
                name: "GoodWith",
                table: "Animals",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "GoodWith" },
                values: new object[] { new DateTime(2020, 4, 21, 11, 13, 6, 652, DateTimeKind.Local).AddTicks(2770), "cat and dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "GoodWith" },
                values: new object[] { new DateTime(2020, 4, 21, 11, 13, 6, 653, DateTimeKind.Local).AddTicks(9370), "cat and dog" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoodWith",
                table: "Animals");

            migrationBuilder.AddColumn<bool>(
                name: "GoodWithOtherAnimals",
                table: "Animals",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "GoodWithOtherAnimals" },
                values: new object[] { new DateTime(2020, 4, 18, 15, 32, 39, 222, DateTimeKind.Local).AddTicks(3350), true });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "GoodWithOtherAnimals" },
                values: new object[] { new DateTime(2020, 4, 18, 15, 32, 39, 223, DateTimeKind.Local).AddTicks(4580), true });
        }
    }
}
