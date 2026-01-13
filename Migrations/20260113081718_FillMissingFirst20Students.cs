using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagement.Migrations
{
    /// <inheritdoc />
    public partial class FillMissingFirst20Students : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Insert the first 20 students conditionally (no explicit identity ids)
            migrationBuilder.Sql(@"
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student1@example.com', N'Học sinh 1', '0977000101', 2, 'S00001', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00001');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student2@example.com', N'Học sinh 2', '0977000102', 3, 'S00002', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00002');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student3@example.com', N'Học sinh 3', NULL, 4, 'S00003', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00003');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student4@example.com', N'Học sinh 4', '0977000104', 5, 'S00004', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00004');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student5@example.com', N'Học sinh 5', '0977000105', 6, 'S00005', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00005');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student6@example.com', N'Học sinh 6', NULL, 7, 'S00006', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00006');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student7@example.com', N'Học sinh 7', '0977000107', 8, 'S00007', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00007');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student8@example.com', N'Học sinh 8', '0977000108', 9, 'S00008', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00008');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student9@example.com', N'Học sinh 9', NULL, 10, 'S00009', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00009');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student10@example.com', N'Học sinh 10', '0977000110', 1, 'S00010', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00010');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student11@example.com', N'Học sinh 11', '0977000111', 2, 'S00011', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00011');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student12@example.com', N'Học sinh 12', NULL, 3, 'S00012', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00012');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student13@example.com', N'Học sinh 13', '0977000113', 4, 'S00013', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00013');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student14@example.com', N'Học sinh 14', '0977000114', 5, 'S00014', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00014');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student15@example.com', N'Học sinh 15', NULL, 6, 'S00015', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00015');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student16@example.com', N'Học sinh 16', '0977000116', 7, 'S00016', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00016');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student17@example.com', N'Học sinh 17', '0977000117', 8, 'S00017', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00017');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student18@example.com', N'Học sinh 18', NULL, 9, 'S00018', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00018');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student19@example.com', N'Học sinh 19', '0977000119', 10, 'S00019', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00019');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student20@example.com', N'Học sinh 20', '0977000120', 1, 'S00020', '2026-01-01T00:00:00.0000000Z' WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00020');
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM students WHERE student_id IN ('S00001','S00002','S00003','S00004','S00005','S00006','S00007','S00008','S00009','S00010','S00011','S00012','S00013','S00014','S00015','S00016','S00017','S00018','S00019','S00020');");
        }
    }
}
