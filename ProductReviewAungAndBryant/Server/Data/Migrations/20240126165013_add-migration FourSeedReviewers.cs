using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductReviewAungAndBryant.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationFourSeedReviewers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 50, 13, 131, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 1, 27, 0, 50, 13, 131, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 50, 13, 131, DateTimeKind.Local).AddTicks(9776), new DateTime(2024, 1, 27, 0, 50, 13, 131, DateTimeKind.Local).AddTicks(9777) });

            migrationBuilder.InsertData(
                table: "Reviewers",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "ReviewerEmail", "ReviewerName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 27, 0, 50, 13, 131, DateTimeKind.Local).AddTicks(9748), new DateTime(2024, 1, 27, 0, 50, 13, 131, DateTimeKind.Local).AddTicks(9769), "Koike12@gmail.com", "Koike12", "System" },
                    { 2, "System", new DateTime(2024, 1, 27, 0, 50, 13, 131, DateTimeKind.Local).AddTicks(9772), new DateTime(2024, 1, 27, 0, 50, 13, 131, DateTimeKind.Local).AddTicks(9773), "Peko1111@gmail.com", "Peko111", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 47, 25, 662, DateTimeKind.Local).AddTicks(5909), new DateTime(2024, 1, 27, 0, 47, 25, 662, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 47, 25, 662, DateTimeKind.Local).AddTicks(5924), new DateTime(2024, 1, 27, 0, 47, 25, 662, DateTimeKind.Local).AddTicks(5925) });
        }
    }
}
