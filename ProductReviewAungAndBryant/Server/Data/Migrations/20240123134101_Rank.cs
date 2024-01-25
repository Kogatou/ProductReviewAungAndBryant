using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductReviewAungAndBryant.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class Rank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviewer",
                table: "Reviewer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Reviewer",
                newName: "Reviewers");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categorys");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reviews",
                newName: "ReviewerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviewers",
                table: "Reviewers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4596), new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4598), new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4316), new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4318), new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4063), new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4080), new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4455), new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4455), new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4458), new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4459), new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4457) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviewers",
                table: "Reviewers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys");

            migrationBuilder.RenameTable(
                name: "Reviewers",
                newName: "Reviewer");

            migrationBuilder.RenameTable(
                name: "Categorys",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "ReviewerId",
                table: "Reviews",
                newName: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviewer",
                table: "Reviewer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 34, 45, 590, DateTimeKind.Local).AddTicks(1282), new DateTime(2024, 1, 22, 22, 34, 45, 590, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 34, 45, 590, DateTimeKind.Local).AddTicks(1290), new DateTime(2024, 1, 22, 22, 34, 45, 590, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(5995), new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(5997), new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Reviewer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(5731), new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Reviewer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(5745), new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(6142), new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(6142), new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(6144), new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(6145), new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(6144) });
        }
    }
}
