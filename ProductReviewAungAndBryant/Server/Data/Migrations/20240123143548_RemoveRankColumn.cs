using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductReviewAungAndBryant.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRankColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rank",
                table: "Reviewers");

            migrationBuilder.AddColumn<string>(
                name: "ReviewerEmail",
                table: "Reviewers",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerEmail" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9163), new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9178), "Koike12@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewerEmail", "ReviewerName" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9181), new DateTime(2024, 1, 23, 22, 35, 48, 784, DateTimeKind.Local).AddTicks(9181), "Peko1111@gmail.com", "Peko111" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewerEmail",
                table: "Reviewers");

            migrationBuilder.AddColumn<int>(
                name: "Rank",
                table: "Reviewers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "DateCreated", "DateUpdated", "Rank" },
                values: new object[] { new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4063), new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4076), 0 });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Rank", "ReviewerName" },
                values: new object[] { new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4080), new DateTime(2024, 1, 23, 21, 41, 1, 831, DateTimeKind.Local).AddTicks(4081), 1, "AnotherUser" });

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
    }
}
