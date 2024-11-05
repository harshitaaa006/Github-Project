namespace FitHub.Models
{
   
    
        public class Challenge
        {
            public int ChallengeId { get; set; }
            public string? ChallengeName { get; set; }
            public string? Description { get; set; }

            // Foreign key for User
            public string? UserId { get; set; }
            public  User? User { get; set; }
        }
    }
