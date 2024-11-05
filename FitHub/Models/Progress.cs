using System;

namespace FitHub.Models
{
    public class Progress
    {
        public int ProgressId { get; set; }
        public string? ProgressName { get; set; }
        public  DateTime DateRecorded { get; set; }
        public double ProgressPercentage { get; set; }

        // Foreign key to associate with the user
        public string? UserId { get; set; }
        public User? User { get; set; }

        // Optional relationships if progress is based on goals or activities
        public int? GoalId { get; set; }
        public Goal? Goal { get; set; }

        public int? ActivityId { get; set; }
        public Activity? Activity { get; set; }
    }
}
