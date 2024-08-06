namespace LearningPlatform.Models
{
    public class AuthorEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid CourseId { get; set; } // внешний ключ (связь 1 к 1)

        public CourseEntity? Course { get; set; } // ссылка на курс
    }
}
