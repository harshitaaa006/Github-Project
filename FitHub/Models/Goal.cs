namespace FitHub.Models
{
    public class Goal
    {
        public int GoalId { get; set; }
        public string? GoalName { get; set; }
        public string? Description { get; set; }
        public bool? IsCompleted { get; set; }

        // Foreign key for User
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
