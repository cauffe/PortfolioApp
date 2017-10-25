
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PortfolioApp.Models
{
    public class ProfileContext:IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Individual>().ToTable("Individual");
            builder.Entity<Organization>().ToTable("Organization");
            builder.Entity<Hobbies>().ToTable("Hobby");

        }
        public ProfileContext(DbContextOptions<ProfileContext> options):base(options)
        {

        }

        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Organization> Organizations { get; set; }

        public DbSet<Hobbies> Hobby { get; set; }


    }
}
