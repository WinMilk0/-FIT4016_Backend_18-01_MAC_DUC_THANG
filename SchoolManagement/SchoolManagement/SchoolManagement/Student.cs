using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SchoolId { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Full name must be between 2-100 characters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Student ID is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Student ID must be 5-20 characters")]
        public string StudentId { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "Phone must be 10 or 11 digits")]
        public string Phone { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Navigation property
        public virtual School School { get; set; }
    }
}