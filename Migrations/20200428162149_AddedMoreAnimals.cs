using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneProject.Migrations
{
    public partial class AddedMoreAnimals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OtherAnimals",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 21, 48, 724, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "GoodWithSmallChildren", "HousingType", "IsActive", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4420), true, "house", true, true });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "GoodWith" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4470), "dog" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "GoodWith", "GoodWithSmallChildren", "HousingType", "IsActive", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4500), "none ", true, "house", true, true });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "GoodWith" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4520), "cat" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "GoodWith", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4540), "cat and dog", false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4570), false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "Breed", "CatOrDog", "DateAdded", "Description", "Gender", "GoodWith", "GoodWithSmallChildren", "HousingType", "ImageUrl", "IsActive", "IsNeutered", "IsVaccinated", "Name", "NeedYard", "RescueCenter", "Zipcode" },
                values: new object[,]
                {
                    { 33, "1 years old", "Domestic Short Hair", "cat", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(5370), "", "Male", "cat", false, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588090482/jenkins_eviv7m.jpg", false, true, true, "Jenkins", false, "PetPal Animal Shelter", "33713" },
                    { 31, "1 years old", "Grey Tabby", "cat", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(5320), "", "Male", "cat and dog", true, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588090486/ricky_skjqft.jpg", true, true, true, "Ricky", false, "Humane Society of Pinellas", "33713" },
                    { 30, "1 years old", "Domestic Long Hair", "cat", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(5300), "", "Female", "none", true, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588090488/whitney_fzymak.jpg", false, true, true, "Whitney", true, "Humane Society of Pinellas", "33713" },
                    { 29, "4 years old", "Domestic Medium hair", "cat", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(5280), "", "Male", "cat and dog", true, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588090489/oswald_j074v2.jpg", false, true, true, "Oswald", true, "Humane Society of Pinellas", "33713" },
                    { 28, "2 years old", "Tabby", "cat", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(5260), "", "Female", "cat", true, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588090489/amber_j0odow.jpg", false, true, true, "Amber", true, "PetPal Animal Shelter", "33713" },
                    { 27, "6 months old", "Domestic Long Hair", "cat", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(5240), "", "Female", "dog", true, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588090490/marley_vlsojk.jpg", false, true, true, "Marley", true, "PetPal Animal Shelter", "33713" },
                    { 26, "9 years old", "Pomeranian", "dog", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(5220), "", "Female", "none", false, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588090092/penny_bzlvft.jpg", false, true, true, "Penny", true, "PetPal Animal Shelter", "33713" },
                    { 25, "8 months old", "Labardor Retriever", "dog", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(5070), "", "Male", "cat and dog", false, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588090091/wilson_nukavk.jpg", false, true, true, "Wilson", true, "Humane Society of Pinellas", "33713" },
                    { 24, "6 years old", "Mixed Breed", "dog", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(5050), "", "Female", "cat", false, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588088809/ginger_r2yi1s.jpg", false, true, true, "Ginger", true, "Humane Society of Pinellas", "33713" },
                    { 23, "4 years old", "Australian Shepard", "dog", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(5030), "", "Female", "dog", false, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588088809/macy_csaskg.jpg", false, true, true, "Macy", true, "Humane Society of Pinellas", "33713" },
                    { 22, "1 years old", "Corgi", "dog", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(5010), "", "Female", "none", false, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588088812/tesla_hb1hsb.jpg", true, true, true, "Tesla", true, "Humane Society of Pinellas", "33713" },
                    { 21, "6 months old", "Labordor Retriever", "dog", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4990), "", "Male", "cat and dog", false, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588088814/zack_d8t07o.jpg", true, true, true, "Zack", true, "PetPal Animal Shelter", "33713" },
                    { 20, "6 months old", "Yorkie", "dog", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4970), "", "Male", "cat", false, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588088814/oliver_o4ep1l.jpg", true, true, true, "Oliver", true, "PetPal Animal Shelter", "33713" },
                    { 19, "2 years old", "Dalmatian", "dog", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4950), "", "Male", "dog", false, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588088816/maverick_sxaj1x.jpg", true, true, true, "Maverick", true, "PetPal Animal Shelter", "33713" },
                    { 18, "5 years old", "Pitbull", "dog", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4930), "", "Female", "dog", true, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588088810/stella_hsa5km.jpg", true, true, true, "Stella", false, "PetPal Animal Shelter", "33713" },
                    { 32, "2 years old", "Sphinx", "cat", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(5340), "", "Female", "none", true, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588090485/sasha_zsz48a.jpg", true, true, true, "Sasha", false, "PetPal Animal Shelter", "33713" },
                    { 17, "3 years old", "Pitbull", "dog", new DateTime(2020, 4, 28, 12, 21, 48, 725, DateTimeKind.Local).AddTicks(4910), "", "Male", "cat", true, "house", "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588088810/blake_wz3o4g.jpg", true, true, true, "Blake", false, "ASPCA", "33713" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.AddColumn<bool>(
                name: "OtherAnimals",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "DateAdded", "GoodWithSmallChildren", "HousingType", "IsActive", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1500), false, "apartment", false, false });

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
                columns: new[] { "DateAdded", "GoodWith", "GoodWithSmallChildren", "HousingType", "IsActive", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1570), "cat", false, "apartment", false, false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "GoodWith" },
                values: new object[] { new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1600), "none" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "GoodWith", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1620), "none", true });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1650), true });

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
                column: "DateAdded",
                value: new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1690));

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

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2020, 4, 27, 13, 48, 2, 721, DateTimeKind.Local).AddTicks(1840));
        }
    }
}
