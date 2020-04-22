using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneProject.Migrations
{
    public partial class AddedNewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFenced",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "LookingFor",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Animals",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "Gender" },
                values: new object[] { new DateTime(2020, 4, 21, 21, 53, 44, 615, DateTimeKind.Local).AddTicks(8500), "Male" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "Gender" },
                values: new object[] { new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(60), "Female" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Breed", "CatOrDog", "DateAdded", "Description", "Gender", "GoodWith", "GoodWithSmallChildren", "HousingType", "ImageUrl", "IsActive", "IsNeutered", "IsVaccinated", "Name", "NeedYard", "RescueCenter", "Zipcode" },
                values: new object[,]
                {
                    { 3, "4 years old", "Golden Retriever", "Dog", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(110), "Buddy is looking for a new family to take him home and play fetch all day and night. His favorite thing is play outside!", "Male", "dog", true, "house", "../images/buddy.jpg", true, false, true, "Buddy", true, "ASPCA", "33713" },
                    { 4, "7 years old", "Terrier", "Dog", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(140), "Sweetie justs wants to curl up on the couch next to you and watch movies all day. She will make the perfect snuggle baby for someone!", "Female", "cat and dog", false, "apartment", "../images/sweetie.jpg", false, true, true, "Sweetie", false, "ASPCA", "33713" },
                    { 5, "3 years old", "Poodle", "Dog", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(160), "Rocco is a very rambunctious poodle with loads of spunky personality. Everyone on your block will know who Rocco is!", "Male", "none", true, "apartment", "../images/rocco.jpg", false, true, true, "Rocco", false, "ASPCA", "33713" },
                    { 6, "2 years old", "Pitbull", "Dog", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(190), "Sophie is a fun loving girl who wants to play always. Throw a frisbee or taking her running, either way, she will keep up!", "Female", "none", true, "house", "../images/sophie.jpg", true, true, true, "Sophie", true, "ASPCA", "33713" },
                    { 7, "3 years old", "Siberian Husky", "Dog", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(210), "Rex would do really well in a home where he is the only animal. He needs a lot of attention as he is a workind dog so someone who can commit to taking long walks with Rex would be perfect!", "Male", "none", false, "house", "../images/rex.jpg", true, true, true, "Rex", true, "ASPCA", "33713" },
                    { 8, "2 years old", "Domestic Short Hair", "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(230), "Chloe wants all the pets in the whole world!", "Female", "cat", false, "apartment", "../images/chloe.jpg", false, true, true, "Chloe", false, "ASPCA", "33713" },
                    { 9, "1 years old", "Persian", "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(260), "Dexter is the laziest Persian cat you have ever met. All he wants to do is be held in your arms while you pet him endlessly until he falls asleep!", "Male", "none", true, "apartment", "../images/dexter.jpg", false, true, true, "Dexter", false, "ASPCA", "33713" },
                    { 10, "1 years old", "Domestic Short Hair", "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(280), "Ella is looking for a new furever home!", "Female", "none", false, "apartment", "../images/ella.jpg", false, true, true, "Ella", false, "ASPCA", "33713" },
                    { 11, "4 years old", "Russian Blue", "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(310), "If you have ever wanted a cat who never stops exploring, you have found him! Simon loves to be outside and roam the outdoors but he will never venture too far from home!", "Male", "cat and dog", true, "house", "../images/simon.jpg", true, true, true, "Simon", true, "ASPCA", "33713" },
                    { 12, "2 years old", "Domestic Long Hair", "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(330), "Sheba will be the princess of the house with an attitude to match...but only because she wants attention!", "Female", "none", true, "apartment", "../images/sheba.jpg", false, true, true, "Sheba", false, "ASPCA", "33713" },
                    { 13, "3 years old", "Domestic Medium Hair", "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(350), "Nala wants nothing more than to find a spot perched high above your head so she can watch her family down below!", "Female", "none", true, "apartment", "../images/nala.jpg", false, true, true, "Nala", false, "ASPCA", "33713" },
                    { 14, " 6 months old", "Brown Tabby", "Cat", new DateTime(2020, 4, 21, 21, 53, 44, 617, DateTimeKind.Local).AddTicks(370), "Just a little baby Harry is, someone love him!", "Male", "cat", true, "apartment", "../images/harry.jpg", false, true, true, "Harry", false, "ASPCA", "33713" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DropColumn(
                name: "LookingFor",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Animals");

            migrationBuilder.AddColumn<bool>(
                name: "IsFenced",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 4, 21, 11, 13, 6, 652, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2020, 4, 21, 11, 13, 6, 653, DateTimeKind.Local).AddTicks(9370));
        }
    }
}
