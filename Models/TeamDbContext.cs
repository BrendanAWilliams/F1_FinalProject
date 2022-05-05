using Microsoft.EntityFrameworkCore;

namespace F1_FinalProject.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext (DbContextOptions<TeamContext> options)
            : base(options)
            {
            }
            public DbSet<Team> Teams {get; set;}
            public DbSet<Driver> Drivers {get; set;}
            public DbSet<Circuit> Circuits {get; set;}
    }
}