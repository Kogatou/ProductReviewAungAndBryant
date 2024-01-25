using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductReviewAungAndBryant.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveReviewIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewID",
                table: "Reviews");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6707), new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6709), new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6419), new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6422), new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6166), new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6183), new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6565), new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6565), new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6568), new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6568), new DateTime(2024, 1, 25, 22, 10, 53, 635, DateTimeKind.Local).AddTicks(6567) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReviewID",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate", "ReviewID" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7777), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7777), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7776), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate", "ReviewID" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 1, 23, 22, 45, 27, 705, DateTimeKind.Local).AddTicks(7779), 2 });
        }
    }
}
