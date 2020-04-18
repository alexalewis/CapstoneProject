using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneProject.Migrations
{
    public partial class SeededFirstAnimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Zipcode",
                table: "Animals",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Animals",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Animals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Animals",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Breed", "CatOrDog", "DateAdded", "Description", "GoodWithOtherAnimals", "GoodWithSmallChildren", "HousingType", "ImageUrl", "IsActive", "IsNeutered", "IsVaccinated", "Name", "NeedYard", "RescueCenter", "Zipcode" },
                values: new object[] { 1, "4 years old", "Greyhound", "Dog", new DateTime(2020, 4, 18, 15, 21, 56, 224, DateTimeKind.Local).AddTicks(4450), "Jack is a retired race dog who wants to spend the rest of his days with a family who will love and care for him. He would do best in a home that has a fenced yard.", true, true, "house", "../images/greyhound.jpg", true, true, true, "Jack", true, "Greyhounds of Florida", "33713" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Animals");

            migrationBuilder.AlterColumn<int>(
                name: "Zipcode",
                table: "Animals",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Animals",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
