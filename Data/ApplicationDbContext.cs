using Microsoft.EntityFrameworkCore;
using SchoolManagement.Models;

namespace SchoolManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<School> Schools { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure unique constraints and relationships
            modelBuilder.Entity<School>(entity =>
            {
                entity.ToTable("schools");
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Id).HasColumnName("id");
                entity.HasIndex(s => s.Name).IsUnique().HasDatabaseName("ux_schools_name");
                entity.Property(s => s.Name).IsRequired().HasMaxLength(200).HasColumnName("name");
                entity.Property(s => s.Principal).IsRequired().HasMaxLength(200).HasColumnName("principal");
                entity.Property(s => s.Address).IsRequired().HasMaxLength(500).HasColumnName("address");
                entity.Property(s => s.CreatedAt).HasColumnName("created_at");
                entity.Property(s => s.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("students");
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Id).HasColumnName("id");
                entity.HasIndex(s => s.StudentId).IsUnique().HasDatabaseName("ux_students_student_id");
                entity.HasIndex(s => s.Email).IsUnique().HasDatabaseName("ux_students_email");

                entity.Property(s => s.SchoolId).IsRequired().HasColumnName("school_id");
                entity.Property(s => s.FullName).IsRequired().HasMaxLength(100).HasColumnName("full_name");
                entity.Property(s => s.StudentId).IsRequired().HasMaxLength(20).HasColumnName("student_id");
                entity.Property(s => s.Email).IsRequired().HasMaxLength(200).HasColumnName("email");
                entity.Property(s => s.Phone).HasMaxLength(11).HasColumnName("phone");
                entity.Property(s => s.CreatedAt).HasColumnName("created_at");
                entity.Property(s => s.UpdatedAt).HasColumnName("updated_at");

                entity.HasOne(s => s.School)
                      .WithMany(sch => sch.Students)
                      .HasForeignKey(s => s.SchoolId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Seed sample data: 10 schools, 20 students
            var seedDate = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var schools = new List<School>();
            // Seed 10 schools (Vietnamese names)
            for (int i = 1; i <= 10; i++)
            {
                schools.Add(new School
                {
                    Id = i,
                    Name = $"Đại học Đại Nam {i}",
                    Principal = "Đại học Đại Nam",
                    Address = $"{i} Xốm, Phú Lâm, Hà Đông, Hà Nội",
                    CreatedAt = seedDate,
                    UpdatedAt = seedDate
                });
            }

            modelBuilder.Entity<School>().HasData(schools);

            var students = new List<Student>();
            int sid = 1;
            for (int i = 1; i <= 40; i++)
            {
                students.Add(new Student
                {
                    Id = sid,
                    SchoolId = (i % 10) + 1,
                    FullName = $"Học sinh {i}",
                    StudentId = $"S{i:00000}",
                    Email = $"student{i}@example.com",
                    Phone =  i % 3 == 0 ? null : $"0977000{100 + i}",
                    CreatedAt = seedDate,
                    UpdatedAt = seedDate
                });
                sid++;
            }

            modelBuilder.Entity<Student>().HasData(students);
        }
    }
}