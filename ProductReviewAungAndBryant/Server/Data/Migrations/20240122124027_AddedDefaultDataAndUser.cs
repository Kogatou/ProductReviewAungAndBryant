using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductReviewAungAndBryant.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "PcPartBrand",
                table: "PcParts");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "PcParts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Reviewer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviewer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Reviewer",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Rank", "ReviewerName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 1, 22, 20, 40, 27, 511, DateTimeKind.Local).AddTicks(6909), new DateTime(2024, 1, 22, 20, 40, 27, 511, DateTimeKind.Local).AddTicks(6922), 0, "Koike12", "System" },
                    { 2, "System", new DateTime(2024, 1, 22, 20, 40, 27, 511, DateTimeKind.Local).AddTicks(6925), new DateTime(2024, 1, 22, 20, 40, 27, 511, DateTimeKind.Local).AddTicks(6926), 1, "AnotherUser", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviewer");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "PcParts");

            migrationBuilder.AddColumn<string>(
                name: "PcPartBrand",
                table: "PcParts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }
    }
}
