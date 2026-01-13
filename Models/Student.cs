using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolManagement.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("School")]
        public int SchoolId { get; set; }

        // Navigation
        public School? School { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FullName { get; set; } = null!;

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string StudentId { get; set; } = null!; // unique

        [Required]
        [EmailAddress]
        [StringLength(200)]
        public string Email { get; set; } = null!; // unique

        [RegularExpression(@"^[0-9]{10,11}$", ErrorMessage = "Phone number must be 10 or 11 digits")]
        [StringLength(11)]
        public string? Phone { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}