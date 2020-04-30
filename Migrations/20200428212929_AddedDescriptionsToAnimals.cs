using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneProject.Migrations
{
    public partial class AddedDescriptionsToAnimals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 949, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9260), "Blake is looking for his best pal. Someone that lets him join in on all of their adventures!" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9290), "Stella is a very sweet girl but can be skittish. She just needs a little time to warm up!" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9310), "Maverick is an amazing dog that will wake you up every morning to remind you its time for his walk!" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "Description", "GoodWith", "HousingType", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9330), "Just a little puppy, Oliver needs someone who ready take him on!", "dog", "apartment", false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9350), "Zack needs all the training a puppy can get!" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateAdded", "Description", "HousingType", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9370), "Tesla is a very energetic girl that loves to for rides in the car!", "apartment", false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9390), "Macy needs a job being that she is an Australian Shepard. Take her running or on a boat ride, either way she will be happy to be out and about with you! " });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateAdded", "Description", "HousingType", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9410), "Ginger would be happy with someone who spends a lot of time at home so she can get her daily dose of snuggles!", "apartment", false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9430), "Wilson is a lab like any other. He loves to play firsbee and give licks to total strangers!" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9450), "Penny is a senior Pomeranian who will follow you around everywhere until she gets little scraps of food for being so cute!" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9480), "Marley would be just fine in a house with dogs as long as she still gets some attention now and then!" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9500), "Amber loves to hang out on high surfaces so that she can see the whole family!" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9520), "Oswald has a very spunky personality and would love to have some other animals in the family!" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9540), "Whitney would be best in a home where she is the only cat that way she doesn't have to share the snuggles!" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateAdded", "Description", "HousingType" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9600), "Ricky is a very sweet cat who just wants to curl up on the end of the couch while you read your favorite book!", "apartment" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateAdded", "Description", "HousingType" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9620), "Sasha is a very special Sphinx cat that needs special attention because of her lack of hair.", "apartment" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateAdded", "Description", "HousingType" },
                values: new object[] { new DateTime(2020, 4, 28, 17, 29, 28, 950, DateTimeKind.Local).AddTicks(9650), "Jenkins is ready for his forever family!", "apartment" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 16, DateTimeKind.Local).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateAdded",
                value: new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9490), "" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9590), "" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9610), "" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateAdded", "Description", "GoodWith", "HousingType", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9630), "", "cat", "house", true });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9660), "" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateAdded", "Description", "HousingType", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9680), "", "house", true });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9700), "" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateAdded", "Description", "HousingType", "NeedYard" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9720), "", "house", true });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9740), "" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9760), "" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9780), "" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9810), "" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9830), "" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateAdded", "Description" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9850), "" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "DateAdded", "Description", "HousingType" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9870), "", "house" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "DateAdded", "Description", "HousingType" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9890), "", "house" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateAdded", "Description", "HousingType" },
                values: new object[] { new DateTime(2020, 4, 28, 12, 25, 32, 17, DateTimeKind.Local).AddTicks(9910), "", "house" });
        }
    }
}
