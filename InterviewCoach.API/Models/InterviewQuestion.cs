namespace InterviewCoach.API.Models
{
    public class InterviewQuestion
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public InterviewSession? Session { get; set; }
        public string Question { get; set; } = string.Empty;
        public string UserAnswer { get; set; } = string.Empty;
        public string AIFeedback { get; set; } = string.Empty;
        public int Score { get; set; }
        public int OrderIndex { get; set; }
        public DateTime AnsweredAt { get; set; } = DateTime.UtcNow;
    }
}