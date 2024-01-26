using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductReviewAungAndBryant.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Reviewers",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "ReviewerEmail", "ReviewerName", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "System", new DateTime(2024, 1, 27, 0, 47, 25, 662, DateTimeKind.Local).AddTicks(5909), new DateTime(2024, 1, 27, 0, 47, 25, 662, DateTimeKind.Local).AddTicks(5922), "Koike123@gmail.com", "Koike123", "System" },
                    { 4, "System", new DateTime(2024, 1, 27, 0, 47, 25, 662, DateTimeKind.Local).AddTicks(5924), new DateTime(2024, 1, 27, 0, 47, 25, 662, DateTimeKind.Local).AddTicks(5925), "Peko11113@gmail.com", "Peko1113", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryBrandName", "CategoryName", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Intel", "CPU", "System", new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9440), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9441), "System" },
                    { 2, "NVDIA", "GPU", "System", new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9442), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9443), "System" }
                });

            migrationBuilder.InsertData(
                table: "PcParts",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "PcPartName", "PcPartPrice", "ReviewId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 0, "System", new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9149), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9150), "Core i-9 14900KF", 850f, 0, "System" },
                    { 2, 0, "System", new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9152), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9152), "RTX 4090", 2000f, 0, "System" }
                });

            migrationBuilder.InsertData(
                table: "Reviewers",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "ReviewerEmail", "ReviewerName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(8848), "Koike12@gmail.com", "Koike12", "System" },
                    { 2, "System", new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(8850), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(8851), "Peko1111@gmail.com", "Peko111", "System" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "PcPartId", "ReviewDate", "ReviewText", "ReviewerId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9293), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9294), "Review1", 1, new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9293), "This is the first review.", 1, "System" },
                    { 2, "System", new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9296), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9297), "Review2", 2, new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9296), "This is the second review.", 2, "System" }
                });
        }
    }
}
