using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductReviewAungAndBryant.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryBrandName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryBrandName", "CategoryName", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Intel", "CPU", "System", new DateTime(2024, 1, 22, 22, 34, 45, 590, DateTimeKind.Local).AddTicks(1282), new DateTime(2024, 1, 22, 22, 34, 45, 590, DateTimeKind.Local).AddTicks(1288), "System" },
                    { 2, "NVDIA", "GPU", "System", new DateTime(2024, 1, 22, 22, 34, 45, 590, DateTimeKind.Local).AddTicks(1290), new DateTime(2024, 1, 22, 22, 34, 45, 590, DateTimeKind.Local).AddTicks(1290), "System" }
                });

            migrationBuilder.InsertData(
                table: "PcParts",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "PcPartName", "PcPartPrice", "ReviewId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 0, "System", new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(5995), new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(5995), "Core i-9 14900KF", 850f, 0, "System" },
                    { 2, 0, "System", new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(5997), new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(5997), "RTX 4090", 2000f, 0, "System" }
                });

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

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "PcPartId", "ReviewDate", "ReviewID", "ReviewText", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(6142), new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(6142), "Review1", 1, new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(6141), 1, "This is the first review.", "System", 1 },
                    { 2, "System", new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(6144), new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(6145), "Review2", 2, new DateTime(2024, 1, 22, 22, 34, 45, 589, DateTimeKind.Local).AddTicks(6144), 2, "This is the second review.", "System", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DeleteData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PcParts",
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

            migrationBuilder.UpdateData(
                table: "Reviewer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 20, 40, 27, 511, DateTimeKind.Local).AddTicks(6909), new DateTime(2024, 1, 22, 20, 40, 27, 511, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Reviewer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 22, 20, 40, 27, 511, DateTimeKind.Local).AddTicks(6925), new DateTime(2024, 1, 22, 20, 40, 27, 511, DateTimeKind.Local).AddTicks(6926) });
        }
    }
}
