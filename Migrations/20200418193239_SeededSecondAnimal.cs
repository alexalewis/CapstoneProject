using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneProject.Migrations
{
    public partial class SeededSecondAnimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 4, 18, 15, 32, 39, 222, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Breed", "CatOrDog", "DateAdded", "Description", "GoodWithOtherAnimals", "GoodWithSmallChildren", "HousingType", "ImageUrl", "IsActive", "IsNeutered", "IsVaccinated", "Name", "NeedYard", "RescueCenter", "Zipcode" },
                values: new object[] { 2, "6 years old", "Tabby", "Cat", new DateTime(2020, 4, 18, 15, 32, 39, 223, DateTimeKind.Local).AddTicks(4580), "Honey is a sweet girl who is looking for someone with a comfy lap and has time to pet her for days.", true, true, "house", "../images/tabby.jpg", false, true, true, "Honey", false, "PetPal Animal Shelter", "33713" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 4, 18, 15, 21, 56, 224, DateTimeKind.Local).AddTicks(4450));
        }
    }
}
