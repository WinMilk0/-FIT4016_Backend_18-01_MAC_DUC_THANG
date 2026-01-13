using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Principal = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CreatedAt", "Name", "Principal", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "1 Elm Street, City", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4072), "Greenwood High School 1", "Principal 1", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4208) },
                    { 2, "2 Elm Street, City", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4322), "Greenwood High School 2", "Principal 2", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4322) },
                    { 3, "3 Elm Street, City", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4325), "Greenwood High School 3", "Principal 3", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4325) },
                    { 4, "4 Elm Street, City", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4326), "Greenwood High School 4", "Principal 4", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4327) },
                    { 5, "5 Elm Street, City", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4336), "Greenwood High School 5", "Principal 5", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4336) },
                    { 6, "6 Elm Street, City", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4340), "Greenwood High School 6", "Principal 6", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4340) },
                    { 7, "7 Elm Street, City", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4342), "Greenwood High School 7", "Principal 7", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4342) },
                    { 8, "8 Elm Street, City", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4343), "Greenwood High School 8", "Principal 8", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4344) },
                    { 9, "9 Elm Street, City", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4345), "Greenwood High School 9", "Principal 9", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4345) },
                    { 10, "10 Elm Street, City", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4350), "Greenwood High School 10", "Principal 10", new DateTime(2026, 1, 13, 7, 5, 43, 278, DateTimeKind.Utc).AddTicks(4351) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Email", "FullName", "Phone", "SchoolId", "StudentId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(3897), "student1@example.com", "Student 1 Fullname", "0977000101", 2, "S00001", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4055) },
                    { 2, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4220), "student2@example.com", "Student 2 Fullname", "0977000102", 3, "S00002", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4220) },
                    { 3, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4225), "student3@example.com", "Student 3 Fullname", null, 4, "S00003", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4226) },
                    { 4, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4229), "student4@example.com", "Student 4 Fullname", "0977000104", 5, "S00004", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4229) },
                    { 5, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4231), "student5@example.com", "Student 5 Fullname", "0977000105", 6, "S00005", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4232) },
                    { 6, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4237), "student6@example.com", "Student 6 Fullname", null, 7, "S00006", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4237) },
                    { 7, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4240), "student7@example.com", "Student 7 Fullname", "0977000107", 8, "S00007", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4240) },
                    { 8, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4242), "student8@example.com", "Student 8 Fullname", "0977000108", 9, "S00008", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4243) },
                    { 9, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4245), "student9@example.com", "Student 9 Fullname", null, 10, "S00009", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4245) },
                    { 10, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4249), "student10@example.com", "Student 10 Fullname", "0977000110", 1, "S00010", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4249) },
                    { 11, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4252), "student11@example.com", "Student 11 Fullname", "0977000111", 2, "S00011", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4252) },
                    { 12, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4254), "student12@example.com", "Student 12 Fullname", null, 3, "S00012", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4254) },
                    { 13, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4258), "student13@example.com", "Student 13 Fullname", "0977000113", 4, "S00013", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4258) },
                    { 14, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4260), "student14@example.com", "Student 14 Fullname", "0977000114", 5, "S00014", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4261) },
                    { 15, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4263), "student15@example.com", "Student 15 Fullname", null, 6, "S00015", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4263) },
                    { 16, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4265), "student16@example.com", "Student 16 Fullname", "0977000116", 7, "S00016", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4265) },
                    { 17, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4268), "student17@example.com", "Student 17 Fullname", "0977000117", 8, "S00017", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4268) },
                    { 18, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4271), "student18@example.com", "Student 18 Fullname", null, 9, "S00018", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4271) },
                    { 19, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4273), "student19@example.com", "Student 19 Fullname", "0977000119", 10, "S00019", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4274) },
                    { 20, new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4285), "student20@example.com", "Student 20 Fullname", "0977000120", 1, "S00020", new DateTime(2026, 1, 13, 7, 5, 43, 279, DateTimeKind.Utc).AddTicks(4285) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schools_Name",
                table: "Schools",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_Email",
                table: "Students",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentId",
                table: "Students",
                column: "StudentId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
