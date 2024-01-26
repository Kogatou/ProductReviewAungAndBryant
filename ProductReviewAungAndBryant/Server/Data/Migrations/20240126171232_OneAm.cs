using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductReviewAungAndBryant.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class OneAm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryBrandName", "CategoryName", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Intel", "CPU", "System", new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(1075), new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(1076), "System" },
                    { 2, "NVDIA", "GPU", "System", new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(1078), new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(1078), "System" }
                });

            migrationBuilder.InsertData(
                table: "PcParts",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "PcPartName", "PcPartPrice", "ReviewId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 0, "System", new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(761), new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(762), "Core i-9 14900KF", 850f, 0, "System" },
                    { 2, 0, "System", new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(764), new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(764), "RTX 4090", 2000f, 0, "System" }
                });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(410), new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(429), new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(431), new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(432), new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "PcPartId", "ReviewDate", "ReviewText", "ReviewerId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(917), new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(917), "Review1", 1, new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(916), "This is the first review.", 1, "System" },
                    { 2, "System", new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(920), new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(920), "Review2", 2, new DateTime(2024, 1, 27, 1, 12, 32, 607, DateTimeKind.Local).AddTicks(919), "This is the second review.", 2, "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 50, 13, 131, DateTimeKind.Local).AddTicks(9748), new DateTime(2024, 1, 27, 0, 50, 13, 131, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 50, 13, 131, DateTimeKind.Local).AddTicks(9772), new DateTime(2024, 1, 27, 0, 50, 13, 131, DateTimeKind.Local).AddTicks(9773) });

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
        }
    }
}
