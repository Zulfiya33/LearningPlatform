namespace LearningPlatform.Models
{
    public class StudentEntity
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public Guid CourseId { get; set; } // внешний ключ

        public List<CourseEntity> Course { get; set; } = [];
    }
}
