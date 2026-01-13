using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class School
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "School name is required")]
        [StringLength(200)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Principal name is required")]
        public string Principal { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // Relationship
        public virtual ICollection<Student> Students { get; set; }
    }
}