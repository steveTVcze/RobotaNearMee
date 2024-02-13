using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RobotaNearMe.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Education> Educations { get; set; }
        public DbSet<JobOffer> JobOffers { get; set; }
        public DbSet<PreviousJobs> PreviousJobs { get; set; }
        public DbSet<User> User {  get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
    }
}