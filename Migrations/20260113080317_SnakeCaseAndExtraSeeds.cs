using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolManagement.Migrations
{
    /// <inheritdoc />
    public partial class SnakeCaseAndExtraSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schools",
                table: "Schools");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "students");

            migrationBuilder.RenameTable(
                name: "Schools",
                newName: "schools");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "students",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "students",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "students",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "students",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "students",
                newName: "student_id");

            migrationBuilder.RenameColumn(
                name: "SchoolId",
                table: "students",
                newName: "school_id");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "students",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "students",
                newName: "created_at");

            migrationBuilder.RenameIndex(
                name: "IX_Students_StudentId",
                table: "students",
                newName: "ux_students_student_id");

            migrationBuilder.RenameIndex(
                name: "IX_Students_SchoolId",
                table: "students",
                newName: "IX_students_school_id");

            migrationBuilder.RenameIndex(
                name: "IX_Students_Email",
                table: "students",
                newName: "ux_students_email");

            migrationBuilder.RenameColumn(
                name: "Principal",
                table: "schools",
                newName: "principal");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "schools",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "schools",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "schools",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "schools",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "schools",
                newName: "created_at");

            migrationBuilder.RenameIndex(
                name: "IX_Schools_Name",
                table: "schools",
                newName: "ux_schools_name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_schools",
                table: "schools",
                column: "id");

            migrationBuilder.UpdateData(
                table: "schools",
                keyColumn: "id",
                keyValue: 1,
                column: "name",
                value: "Đại học Đại Nam 1");

            migrationBuilder.InsertData(
                table: "schools",
                columns: new[] { "id", "address", "created_at", "name", "principal", "updated_at" },
                values: new object[,]
                {
                    { 2, "2 Xốm, Phú Lâm, Hà Đông, Hà Nội", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đại học Đại Nam 2", "Đại học Đại Nam", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3, "3 Xốm, Phú Lâm, Hà Đông, Hà Nội", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đại học Đại Nam 3", "Đại học Đại Nam", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4, "4 Xốm, Phú Lâm, Hà Đông, Hà Nội", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đại học Đại Nam 4", "Đại học Đại Nam", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5, "5 Xốm, Phú Lâm, Hà Đông, Hà Nội", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đại học Đại Nam 5", "Đại học Đại Nam", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6, "6 Xốm, Phú Lâm, Hà Đông, Hà Nội", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đại học Đại Nam 6", "Đại học Đại Nam", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7, "7 Xốm, Phú Lâm, Hà Đông, Hà Nội", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đại học Đại Nam 7", "Đại học Đại Nam", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8, "8 Xốm, Phú Lâm, Hà Đông, Hà Nội", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đại học Đại Nam 8", "Đại học Đại Nam", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9, "9 Xốm, Phú Lâm, Hà Đông, Hà Nội", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đại học Đại Nam 9", "Đại học Đại Nam", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10, "10 Xốm, Phú Lâm, Hà Đông, Hà Nội", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Đại học Đại Nam 10", "Đại học Đại Nam", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 1,
                column: "school_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 2,
                column: "school_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 3,
                column: "school_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 4,
                column: "school_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 5,
                column: "school_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 6,
                column: "school_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 7,
                column: "school_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 8,
                column: "school_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 9,
                column: "school_id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 11,
                column: "school_id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 12,
                column: "school_id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 13,
                column: "school_id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 14,
                column: "school_id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 15,
                column: "school_id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 16,
                column: "school_id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 17,
                column: "school_id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 18,
                column: "school_id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "id",
                keyValue: 19,
                column: "school_id",
                value: 10);

            // Insert students without explicit identity ids (use INSERT ... WHERE NOT EXISTS to avoid duplicates)
            migrationBuilder.Sql(@"
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student21@example.com', N'Học sinh 21', NULL, 2, 'S00021', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00021');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student22@example.com', N'Học sinh 22', '0977000122', 3, 'S00022', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00022');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student23@example.com', N'Học sinh 23', '0977000123', 4, 'S00023', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00023');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student24@example.com', N'Học sinh 24', NULL, 5, 'S00024', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00024');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student25@example.com', N'Học sinh 25', '0977000125', 6, 'S00025', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00025');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student26@example.com', N'Học sinh 26', '0977000126', 7, 'S00026', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00026');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student27@example.com', N'Học sinh 27', NULL, 8, 'S00027', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00027');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student28@example.com', N'Học sinh 28', '0977000128', 9, 'S00028', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00028');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student29@example.com', N'Học sinh 29', '0977000129', 10, 'S00029', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00029');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student30@example.com', N'Học sinh 30', NULL, 1, 'S00030', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00030');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student31@example.com', N'Học sinh 31', '0977000131', 2, 'S00031', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00031');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student32@example.com', N'Học sinh 32', '0977000132', 3, 'S00032', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00032');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student33@example.com', N'Học sinh 33', NULL, 4, 'S00033', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00033');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student34@example.com', N'Học sinh 34', '0977000134', 5, 'S00034', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00034');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student35@example.com', N'Học sinh 35', '0977000135', 6, 'S00035', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00035');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student36@example.com', N'Học sinh 36', NULL, 7, 'S00036', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00036');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student37@example.com', N'Học sinh 37', '0977000137', 8, 'S00037', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00037');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student38@example.com', N'Học sinh 38', '0977000138', 9, 'S00038', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00038');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student39@example.com', N'Học sinh 39', NULL, 10, 'S00039', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00039');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student40@example.com', N'Học sinh 40', '0977000140', 1, 'S00040', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00040');
");

            migrationBuilder.AddForeignKey(
                name: "FK_students_schools_school_id",
                table: "students",
                column: "school_id",
                principalTable: "schools",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_schools_school_id",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_schools",
                table: "schools");

            // Remove the students inserted by this migration by student_id to avoid relying on identity values
            migrationBuilder.Sql(@"
DELETE FROM students WHERE student_id IN ('S00021','S00022','S00023','S00024','S00025','S00026','S00027','S00028','S00029','S00030','S00031','S00032','S00033','S00034','S00035','S00036','S00037','S00038','S00039');
");

            // Remove any inserted students by student_id (covers S00021..S00040)
            migrationBuilder.Sql(@"
DELETE FROM students WHERE student_id IN ('S00021','S00022','S00023','S00024','S00025','S00026','S00027','S00028','S00029','S00030','S00031','S00032','S00033','S00034','S00035','S00036','S00037','S00038','S00039','S00040');
");

            migrationBuilder.DeleteData(
                table: "schools",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "schools",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "schools",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "schools",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "schools",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "schools",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "schools",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "schools",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "schools",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "schools",
                newName: "Schools");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Students",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Students",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Students",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "student_id",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "school_id",
                table: "Students",
                newName: "SchoolId");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "Students",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Students",
                newName: "CreatedAt");

            migrationBuilder.RenameIndex(
                name: "ux_students_student_id",
                table: "Students",
                newName: "IX_Students_StudentId");

            migrationBuilder.RenameIndex(
                name: "ux_students_email",
                table: "Students",
                newName: "IX_Students_Email");

            migrationBuilder.RenameIndex(
                name: "IX_students_school_id",
                table: "Students",
                newName: "IX_Students_SchoolId");

            migrationBuilder.RenameColumn(
                name: "principal",
                table: "Schools",
                newName: "Principal");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Schools",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Schools",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Schools",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Schools",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Schools",
                newName: "CreatedAt");

            migrationBuilder.RenameIndex(
                name: "ux_schools_name",
                table: "Schools",
                newName: "IX_Schools_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schools",
                table: "Schools",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Đại học Đại Nam");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                column: "SchoolId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                column: "SchoolId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
