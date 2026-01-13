using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using SchoolManagement.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolManagement.Tests
{
    [TestClass]
    public class StudentValidationTests
    {
        [TestMethod]
        public void Student_WithInvalidPhone_FailsValidation()
        {
            var student = new Student
            {
                FullName = "AB",
                StudentId = "S00001",
                Email = "student@example.com",
                Phone = "123",
                SchoolId = 1
            };

            var ctx = new ValidationContext(student);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(student, ctx, results, true);

            Assert.IsFalse(isValid);
            Assert.IsTrue(results.Any(r => r.MemberNames != null && r.MemberNames.Contains("Phone")));
        }
    }
}