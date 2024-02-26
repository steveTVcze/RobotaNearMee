using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace RobotaNearMe.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Education> Educations { get; set; }
        public DbSet<JobOffer> JobOffers { get; set; }
        public DbSet<PreviousJobs> PreviousJobs { get; set; }
        public DbSet<User> User {  get; set; }
        public DbSet<JobField> JobFields { get; set; }
        public DbSet<CompanyAdmin> CompanyAdmins { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<PrevJobsInUser> PrevJobsInUsers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
    }
}