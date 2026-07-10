namespace InterviewCoach.API.Models
{
    public class InterviewSession
    {
        public int Id { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public string Difficulty { get; set; } = string.Empty;
        public int TotalQuestions { get; set; }
        public double AverageScore { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<InterviewQuestion> Questions { get; set; } = new();
    }
}