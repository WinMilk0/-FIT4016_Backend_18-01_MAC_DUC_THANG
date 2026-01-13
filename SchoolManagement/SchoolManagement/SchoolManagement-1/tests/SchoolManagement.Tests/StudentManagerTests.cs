using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolManagement.Data;
using SchoolManagement.Models;
using SchoolManagement.Services;
using System;
using System.Linq;
using Xunit;

namespace SchoolManagement.Tests
{
    public class StudentManagerTests : IDisposable
    {
        private readonly SchoolDbContext _dbContext;
        private readonly StudentManager _studentManager;

        public StudentManagerTests()
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<SchoolDbContext>(options =>
                    options.UseInMemoryDatabase("TestDatabase"))
                .BuildServiceProvider();

            _dbContext = serviceProvider.GetService<SchoolDbContext>();
            _studentManager = new StudentManager(_dbContext);
        }

        [Fact]
        public void AddStudent_ShouldAddStudent_WhenValid()
        {
            var student = new Student { FullName = "John Doe", StudentId = "S123", Email = "john@example.com", SchoolId = 1 };

            _studentManager.AddStudent(student);

            var addedStudent = _dbContext.Students.FirstOrDefault(s => s.StudentId == "S123");
            Assert.NotNull(addedStudent);
            Assert.Equal("John Doe", addedStudent.FullName);
        }

        [Fact]
        public void UpdateStudent_ShouldUpdateStudent_WhenExists()
        {
            var student = new Student { FullName = "Jane Doe", StudentId = "S124", Email = "jane@example.com", SchoolId = 1 };
            _studentManager.AddStudent(student);

            _studentManager.Update(student.Id, "Jane Smith", "jane.smith@example.com", "123456789", 1);

            var updatedStudent = _dbContext.Students.Find(student.Id);
            Assert.Equal("Jane Smith", updatedStudent.FullName);
            Assert.Equal("jane.smith@example.com", updatedStudent.Email);
        }

        [Fact]
        public void DeleteStudent_ShouldRemoveStudent_WhenConfirmed()
        {
            var student = new Student { FullName = "Mark Smith", StudentId = "S125", Email = "mark@example.com", SchoolId = 1 };
            _studentManager.AddStudent(student);

            _studentManager.Delete(student.Id);

            var deletedStudent = _dbContext.Students.Find(student.Id);
            Assert.Null(deletedStudent);
        }

        [Fact]
        public void DisplayAll_ShouldReturnPaginatedStudents()
        {
            for (int i = 1; i <= 25; i++)
            {
                _studentManager.AddStudent(new Student { FullName = $"Student {i}", StudentId = $"S{i}", Email = $"student{i}@example.com", SchoolId = 1 });
            }

            var students = _studentManager.DisplayAll(1);
            Assert.Equal(10, students.Count());
        }

        public void Dispose()
        {
            _dbContext.Database.EnsureDeleted();
            _dbContext.Dispose();
        }
    }
}