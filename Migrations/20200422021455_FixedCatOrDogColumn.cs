using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneProject.Migrations
{
    public partial class FixedCatOrDogColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "dog", new DateTime(2020, 4, 21, 22, 14, 55, 147, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "cat", new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "dog", new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "dog", new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "dog", new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "dog", new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "dog", new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "cat", new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "cat", new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "cat", new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "cat", new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "cat", new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "cat", new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "cat", new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7950) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Dog", new DateTime(2020, 4, 21, 21, 53, 44, 615, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Dog", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Dog", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Dog", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Dog", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Dog", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CatOrDog", "DateAdded" },
                values: new object[] { "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(370) });
        }
    }
}
