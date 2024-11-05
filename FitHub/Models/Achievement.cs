using System;

namespace FitHub.Models
{
    public class Achievement
    {
        public int AchievementId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DateAchieved { get; set; }

        // Foreign key to associate with the user
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
