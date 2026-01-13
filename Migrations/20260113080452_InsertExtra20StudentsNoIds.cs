using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolManagement.Migrations
{
    /// <inheritdoc />
    public partial class InsertExtra20StudentsNoIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Insert 20 students without specifying the identity id column; use WHERE NOT EXISTS to avoid duplicates
            migrationBuilder.Sql(@"
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student21@example.com', N'Học sinh 21', NULL, 2, 'S00021', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00021');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student22@example.com', N'Học sinh 22', '0977000122', 3, 'S00022', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00022');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student23@example.com', N'Học sinh 23', '0977000123', 4, 'S00023', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00023');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student24@example.com', N'Học sinh 24', NULL, 5, 'S00024', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00024');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student25@example.com', N'Học sinh 25', '0977000125', 6, 'S00025', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00025');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student26@example.com', N'Học sinh 26', '0977000126', 7, 'S00026', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00026');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student27@example.com', N'Học sinh 27', NULL, 8, 'S00027', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00027');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student28@example.com', N'Học sinh 28', '0977000128', 9, 'S00028', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00028');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student29@example.com', N'Học sinh 29', '0977000129', 10, 'S00029', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00029');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student30@example.com', N'Học sinh 30', NULL, 1, 'S00030', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00030');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student31@example.com', N'Học sinh 31', '0977000131', 2, 'S00031', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00031');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student32@example.com', N'Học sinh 32', '0977000132', 3, 'S00032', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00032');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student33@example.com', N'Học sinh 33', NULL, 4, 'S00033', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00033');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student34@example.com', N'Học sinh 34', '0977000134', 5, 'S00034', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00034');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student35@example.com', N'Học sinh 35', '0977000135', 6, 'S00035', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00035');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student36@example.com', N'Học sinh 36', NULL, 7, 'S00036', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00036');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student37@example.com', N'Học sinh 37', '0977000137', 8, 'S00037', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00037');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student38@example.com', N'Học sinh 38', '0977000138', 9, 'S00038', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00038');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student39@example.com', N'Học sinh 39', NULL, 10, 'S00039', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00039');
INSERT INTO students (created_at, email, full_name, phone, school_id, student_id, updated_at)
SELECT '2026-01-01T00:00:00.0000000Z', 'student40@example.com', N'Học sinh 40', '0977000140', 1, 'S00040', '2026-01-01T00:00:00.0000000Z'
WHERE NOT EXISTS (SELECT 1 FROM students WHERE student_id = 'S00040');
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
