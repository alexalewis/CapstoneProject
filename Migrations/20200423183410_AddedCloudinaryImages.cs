using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CapstoneProject.Migrations
{
    public partial class AddedCloudinaryImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 369, DateTimeKind.Local).AddTicks(3900), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665893/greyhound_yqahgy.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 370, DateTimeKind.Local).AddTicks(6200), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665853/tabby_vuruuf.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 370, DateTimeKind.Local).AddTicks(6250), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665858/buddy_p2ej5y.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 370, DateTimeKind.Local).AddTicks(6280), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665839/sweetie_plo8jp.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 370, DateTimeKind.Local).AddTicks(6300), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665873/rocco_lrufwb.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 370, DateTimeKind.Local).AddTicks(6330), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665871/sophie_ol55co.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 370, DateTimeKind.Local).AddTicks(6360), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665873/rex_tfv6ya.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 370, DateTimeKind.Local).AddTicks(6380), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665870/chloe_uyhyyu.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 370, DateTimeKind.Local).AddTicks(6400), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665887/dexter_qa3x0v.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 370, DateTimeKind.Local).AddTicks(6420), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665883/ella_kknwpn.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 370, DateTimeKind.Local).AddTicks(6450), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665891/simon_kf7ksd.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 370, DateTimeKind.Local).AddTicks(6470), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665886/sheba_q2wn4u.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 370, DateTimeKind.Local).AddTicks(6560), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665885/nala_yyucg3.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 23, 14, 34, 10, 370, DateTimeKind.Local).AddTicks(6590), "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665885/harry_rtszsw.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 147, DateTimeKind.Local).AddTicks(6360), "../images/greyhound.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7580), "../images/tabby.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7630), "../images/buddy.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7660), "../images/sweetie.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7680), "../images/rocco.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7710), "../images/sophie.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7730), "../images/rex.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7750), "../images/chloe.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7770), "../images/dexter.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7790), "../images/ella.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7810), "../images/simon.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7900), "../images/sheba.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7930), "../images/nala.jpg" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateAdded", "ImageUrl" },
                values: new object[] { new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7950), "../images/harry.jpg" });
        }
    }
}
