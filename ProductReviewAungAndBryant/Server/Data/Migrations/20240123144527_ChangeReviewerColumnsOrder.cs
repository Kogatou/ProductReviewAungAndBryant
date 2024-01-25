using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductReviewAungAndBryant.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeReviewerColumnsOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7965), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7967), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7615), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7618), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7287), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7306), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7777), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7777), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7779) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 35, 48, 785, DateTimeKind.Local).AddTicks(24), new DateTime(2024, 1, 23, 22, 35, 48, 785, DateTimeKind.Local).AddTicks(25) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 35, 48, 785, DateTimeKind.Local).AddTicks(27), new DateTime(2024, 1, 23, 22, 35, 48, 785, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9622), new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9625), new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9163), new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9844), new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9844), new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9847), new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9848), new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9847) });
        }
    }
}
