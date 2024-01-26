using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductReviewAungAndBryant.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class SatDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryPcPart_Categorys_CategoriesId",
                table: "CategoryPcPart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys");

            migrationBuilder.RenameTable(
                name: "Categorys",
                newName: "Categories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Reviews",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Reviews",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Reviewers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Reviewers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "PcParts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "PcParts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9440), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9442), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9149), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9152), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(8850), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9293), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9294), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9296), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9297), new DateTime(2024, 1, 27, 0, 24, 28, 347, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryPcPart_Categories_CategoriesId",
                table: "CategoryPcPart",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryPcPart_Categories_CategoriesId",
                table: "CategoryPcPart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categorys");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Reviewers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Reviewers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "PcParts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "PcParts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateUpdated",
                table: "Categorys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Categorys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4863), new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Categorys",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4865), new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4558), new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "PcParts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4561), new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4229), new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4245), new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4713), new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4713), new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReviewDate" },
                values: new object[] { new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4716), new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4716), new DateTime(2024, 1, 26, 2, 18, 29, 144, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryPcPart_Categorys_CategoriesId",
                table: "CategoryPcPart",
                column: "CategoriesId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
