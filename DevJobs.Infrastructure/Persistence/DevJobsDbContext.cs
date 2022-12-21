using System.Reflection;
using DevJobs.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevJobs.Infrastructure.Persistence
{
    public class DevJobsDbContext : DbContext
    {
        public DevJobsDbContext(DbContextOptions<DevJobsDbContext> options) : base(options)
        {

        }
        public DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}