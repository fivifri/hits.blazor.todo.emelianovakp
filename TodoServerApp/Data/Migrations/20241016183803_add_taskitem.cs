using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "CreatedDate", "Description", "FinishDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 16, 23, 38, 2, 617, DateTimeKind.Local).AddTicks(743), "100 times", new DateTime(2024, 10, 17, 0, 0, 0, 0, DateTimeKind.Local), "Pet the cat" },
                    { 2, new DateTime(2024, 10, 16, 23, 38, 2, 617, DateTimeKind.Local).AddTicks(799), "Or not?", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finish this course" },
                    { 3, new DateTime(2024, 10, 16, 23, 38, 2, 617, DateTimeKind.Local).AddTicks(807), ".-.", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Homework" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");
        }
    }
}
