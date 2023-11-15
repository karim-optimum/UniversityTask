using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options){}
        
        public DbSet<University> Universities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(uc => new { uc.StudentId, uc.CourseId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(uc => uc.Student)
                .WithMany(u => u.StudentCourses)
                .HasForeignKey(uc => uc.StudentId);

            modelBuilder.Entity<TeacherCourse>()
                .HasOne(uc => uc.Teacher)
                .WithMany(c => c.TeacherCourses)
                .HasForeignKey(uc => uc.TeacherId);

            modelBuilder.Entity<User>()
                .HasOne(u => u.University)
                .WithMany(u => u.Users)
                .HasForeignKey(u => u.UniversityId);
        }
    }
}
