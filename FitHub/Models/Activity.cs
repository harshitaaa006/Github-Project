using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitHub.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }

        public string? ActivityName { get; set; }
        public DateTime DateCompleted { get; set; }
        public string? Status { get; set; }

        public string? UserId { get; set; }
        public User? User { get; set; } // Navigation property

        public ICollection<Goal> Goals { get; set; }

        public Activity()
        {
            Goals = new List<Goal>();
        }
    }
}
