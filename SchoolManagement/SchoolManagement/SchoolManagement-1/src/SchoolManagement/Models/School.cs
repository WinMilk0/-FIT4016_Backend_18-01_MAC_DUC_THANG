using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class School
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}