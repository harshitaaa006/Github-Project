using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace FitHub.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public string? Difficulty { get; set; }
        public string? Description { get; set; }
     

       
    }
}
