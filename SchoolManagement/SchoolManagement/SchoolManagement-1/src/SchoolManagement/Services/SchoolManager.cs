using Microsoft.EntityFrameworkCore;
using SchoolManagement.Models;
using SchoolManagement.Data;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Services
{
    public class SchoolManager
    {
        private readonly SchoolDbContext _db = new SchoolDbContext();

        // 1. CREATE a new school
        public void AddSchool(School school)
        {
            try
            {
                ValidateObject(school);
                _db.Schools.Add(school);
                _db.SaveChanges();
                Console.WriteLine(">>> Success: School added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($">>> Error: {ex.Message}");
            }
        }

        // 2. READ all schools
        public void DisplayAll()
        {
            var list = _db.Schools.OrderBy(s => s.Id).ToList();

            Console.WriteLine("\n--- SCHOOL LIST ---");
            Console.WriteLine("{0,-5} | {1,-30} | {2,-20}", "ID", "School Name", "Location");
            foreach (var school in list)
            {
                Console.WriteLine("{0,-5} | {1,-30} | {2,-20}", 
                    school.Id, school.Name, school.Location);
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