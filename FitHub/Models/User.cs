using Microsoft.AspNetCore.Identity;
namespace FitHub.Models
{
    public class User : IdentityUser
    {
        // Additional properties for the user
        public string Name { get; set; }
        public ICollection<Activity> Activities { get; set; }
        public ICollection<Goal> Goals { get; set; }
     
        public ICollection<Workout> Workouts { get; set; }
        public ICollection<Challenge> Challenges { get; set; }

        // Constructor to initialize collections
        public User()
        {
            Activities = new List<Activity>();
            Goals = new List<Goal>();
            Workouts = new List<Workout>();
            Challenges = new List<Challenge>();
        }
    }
}
