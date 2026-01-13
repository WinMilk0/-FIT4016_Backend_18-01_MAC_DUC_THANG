using Microsoft.EntityFrameworkCore;
using SchoolManagement.Models;

namespace SchoolManagement.Data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Kết nối Database local
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SchoolManagement;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình Unique Constraints bằng Fluent API
            modelBuilder.Entity<School>().HasIndex(s => s.Name).IsUnique();
            modelBuilder.Entity<Student>().HasIndex(s => s.StudentId).IsUnique();
            modelBuilder.Entity<Student>().HasIndex(s => s.Email).IsUnique();

            // Seed Data 10 Schools & 20 Students (Requirement 2)
            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var schools = Enumerable.Range(1, 10).Select(i => new School {
                Id = i, Name = $"International School {i}", Principal = $"Mr. Manager {i}", Address = $"{i} Wall Street"
            }).ToArray();

            modelBuilder.Entity<School>().HasData(schools);

            var students = Enumerable.Range(1, 20).Select(i => new Student {
                Id = i,
                SchoolId = (i % 10) + 1,
                FullName = $"Student Name {i}",
                StudentId = $"STU{1000 + i}",
                Email = $"student{i}@edu.vn",
                Phone = "0901234567"
            }).ToArray();

            modelBuilder.Entity<Student>().HasData(students);
        }
    }
}