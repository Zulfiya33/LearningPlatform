namespace LearningPlatform.Models
{
    public class CourseEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        public Guid AuthorID { get; set; }// внешний ключ
        public AuthorEntity? Author { get; set; }

        public List<LessonEntity> Lessons { get; set; } = [];//один курс множество уроков
        public List<StudentEntity> Students { get; set; } = [];
    }
}
