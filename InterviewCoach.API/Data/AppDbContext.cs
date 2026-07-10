using Microsoft.EntityFrameworkCore;
using InterviewCoach.API.Models;

namespace InterviewCoach.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<InterviewSession> Sessions { get; set; }
        public DbSet<InterviewQuestion> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InterviewQuestion>()
                .HasOne(q => q.Session)
                .WithMany(s => s.Questions)
                .HasForeignKey(q => q.SessionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}