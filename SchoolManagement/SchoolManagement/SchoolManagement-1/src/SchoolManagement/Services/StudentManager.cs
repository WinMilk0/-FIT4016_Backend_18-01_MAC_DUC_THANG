using Microsoft.EntityFrameworkCore;
using SchoolManagement.Models;
using SchoolManagement.Data;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Services
{
    public class StudentManager
    {
        private readonly SchoolDbContext _db;

        public StudentManager(SchoolDbContext db)
        {
            _db = db;
        }

        // 1. CREATE with Validation
        public void AddStudent(Student student)
        {
            try {
                ValidateObject(student);
                _db.Students.Add(student);
                _db.SaveChanges();
                Console.WriteLine(">>> Success: Student added successfully.");
            }
            catch (Exception ex) {
                Console.WriteLine($">>> Error: {ex.Message}");
            }
        }

        // 2. READ with Pagination (10 students per page)
        public void DisplayAll(int page = 1)
        {
            int pageSize = 10;
            var list = _db.Students.Include(s => s.School)
                                   .OrderBy(s => s.Id)
                                   .Skip((page - 1) * pageSize)
                                   .Take(pageSize).ToList();

            Console.WriteLine($"\n--- STUDENT LIST (PAGE {page}) ---");
            Console.WriteLine("{0,-5} | {1,-20} | {2,-15} | {3,-20} | {4}", "ID", "Full Name", "Student ID", "Email", "School");
            foreach (var s in list) {
                Console.WriteLine("{0,-5} | {1,-20} | {2,-15} | {3,-20} | {4}", 
                    s.Id, s.FullName, s.StudentId, s.Email, s.School.Name);
            }
        }

        // 3. UPDATE
        public void Update(int id, string name, string email, string phone, int schoolId)
        {
            var existing = _db.Students.Find(id);
            if (existing == null) {
                Console.WriteLine(">>> Error: Student not found.");
                return;
            }

            existing.FullName = name;
            existing.Email = email;
            existing.Phone = phone;
            existing.SchoolId = schoolId;
            existing.UpdatedAt = DateTime.Now;

            _db.SaveChanges();
            Console.WriteLine(">>> Success: Student updated successfully.");
        }

        // 4. DELETE with Confirmation
        public void Delete(int id)
        {
            var student = _db.Students.Find(id);
            if (student == null) return;

            Console.Write($"Are you sure you want to delete {student.FullName}? (y/n): ");
            if (Console.ReadLine().ToLower() == "y") {
                _db.Students.Remove(student);
                _db.SaveChanges();
                Console.WriteLine(">>> Success: Student removed.");
            }
        }

        // Helper: Validate Data Annotations manually
        private void ValidateObject(object obj)
        {
            var context = new ValidationContext(obj);
            Validator.ValidateObject(obj, context, validateAllProperties: true);
        }
    }
}