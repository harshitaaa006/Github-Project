using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using FitHub.Models;

namespace FitHub.Data
{
    // FitHubContext should inherit from IdentityDbContext<User>
    public class FitHubContext : IdentityDbContext<User>
    {
        // Constructor accepting options
        public FitHubContext(DbContextOptions<FitHubContext> options)
            : base(options)
        {
        }

        // Define DbSet properties for the models
        public DbSet<Activity> Activities { get; set; } = default!;
        public DbSet<Challenge> Challenges { get; set; } = default!;
        public DbSet<Goal> Goals { get; set; } = default!;
        public DbSet<Achievement> Achievements { get; set; } = default!;
        public DbSet<Workout> Workouts { get; set; } = default!;
        public DbSet<Progress> Progresses { get; set; } = default!;
    }
}
