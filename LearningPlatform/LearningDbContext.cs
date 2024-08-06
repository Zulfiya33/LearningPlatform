using LearningPlatform.Configurations;
using LearningPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningPlatform
{
    public class LearningDbContext(DbContextOptions<LearningDbContext> options): DbContext(options)
    {
        
        public DbSet<CourseEntity> Courses { get; set; } // создает экзмепляр при вызовве DbSet из конструктора производного типа
        public DbSet<LessonEntity> Lessons { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<StudentEntity> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration()); // передача экземпляра конфигурации
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new LessonConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
