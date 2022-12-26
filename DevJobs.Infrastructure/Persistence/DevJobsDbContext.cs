using System.Reflection;
using DevJobs.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevJobs.Infrastructure.Persistence
{
    public class DevJobsDbContext : DbContext
    {
        public DevJobsDbContext(DbContextOptions<DevJobsDbContext> options) : base(options)
        {
            new Job("FullStack Developer", "Create and building APIs", "DevLand", "https://devland.net", true, 5000, "https://devland.net/jobs/fullstackdeveloper1", 1);
        }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}