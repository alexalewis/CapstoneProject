using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneProject.Migrations
{
    public partial class UpdatedSeededAnimals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 4, 27, 13, 48, 2, 719, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "GoodWith", "GoodWithSmallChildren", "HousingType" },
                values: new object[] { new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1500), "cat", false, "apartment" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "GoodWith" },
                values: new object[] { new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1550), "cat and dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "GoodWith" },
                values: new object[] { new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1570), "cat" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "HousingType", "IsActive", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1600), "house", true, true });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1620), "Sophie is a fun loving girl who wants to play always. Throw a frisbee or take her running, either way, she will keep up!" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "Description", "GoodWithSmallChildren" },
                values: new object[] { new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1650), "Rex would do really well in a home where he is the only animal. He needs a lot of attention as he is a working dog so someone who can commit to taking long walks with Rex would be perfect!", true });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "GoodWith", "GoodWithSmallChildren" },
                values: new object[] { new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1690), "cat", false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Breed", "CatOrDog", "DateAdded", "Description", "Gender", "GoodWith", "GoodWithSmallChildren", "HousingType", "ImageUrl", "IsActive", "IsNeutered", "IsVaccinated", "Name", "NeedYard", "RescueCenter", "Zipcode" },
                values: new object[,]
                {
                    { 15, " 1 years old", "Pug", "dog", new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1820), "Maggie loves to be a couch potato and will snuggle up right next to you!", "Female", "cat and dog", true, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588008900/maggie_mvuo8d.jpg", true, true, true, "Maggie", true, "PetPal Animal Shelter", "33713" },
                    { 16, "5 years old", "French Bulldog", "dog", new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1840), "Dunkin is a very athletic dog that loves to play firsbee or pull you on your skateboard!", "Male", "none", true, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588009236/dunkin_glzbgz.jpg", true, true, true, "Dunkin", true, "PetPal Animal Shelter", "33713" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 4, 23, 19, 43, 31, 354, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "GoodWith", "GoodWithSmallChildren", "HousingType" },
                values: new object[] { new DateTime(2020, 4, 23, 19, 43, 31, 356, DateTimeKind.Local).AddTicks(1710), "cat and dog", true, "house" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "GoodWith" },
                values: new object[] { new DateTime(2020, 4, 23, 19, 43, 31, 356, DateTimeKind.Local).AddTicks(1760), "dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "GoodWith" },
                values: new object[] { new DateTime(2020, 4, 23, 19, 43, 31, 356, DateTimeKind.Local).AddTicks(1790), "cat and dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "HousingType", "IsActive", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 23, 19, 43, 31, 356, DateTimeKind.Local).AddTicks(1810), "apartment", false, false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 23, 19, 43, 31, 356, DateTimeKind.Local).AddTicks(1840), "Sophie is a fun loving girl who wants to play always. Throw a frisbee or taking her running, either way, she will keep up!" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "Description", "GoodWithSmallChildren" },
                values: new object[] { new DateTime(2020, 4, 23, 19, 43, 31, 356, DateTimeKind.Local).AddTicks(1860), "Rex would do really well in a home where he is the only animal. He needs a lot of attention as he is a workind dog so someone who can commit to taking long walks with Rex would be perfect!", false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2020, 4, 23, 19, 43, 31, 356, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "GoodWith", "GoodWithSmallChildren" },
                values: new object[] { new DateTime(2020, 4, 23, 19, 43, 31, 356, DateTimeKind.Local).AddTicks(1980), "none", true });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2020, 4, 23, 19, 43, 31, 356, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2020, 4, 23, 19, 43, 31, 356, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2020, 4, 23, 19, 43, 31, 356, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2020, 4, 23, 19, 43, 31, 356, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2020, 4, 23, 19, 43, 31, 356, DateTimeKind.Local).AddTicks(2080));
        }
    }
}
