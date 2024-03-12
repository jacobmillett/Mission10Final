using Microsoft.EntityFrameworkCore;


namespace Mission10_API.Data
{
    public class BowlerContext : DbContext
    {
        public BowlerContext(DbContextOptions<BowlerContext> options) : base(options) { }

        public DbSet<Bowlers> Bowlers { get; set;}

        public DbSet<Teams> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teams>().HasData(
                new Teams { TeamID = 1, TeamName = "Marlins" },
                new Teams { TeamID = 2, TeamName = "Sharks" },
                new Teams { TeamID = 3, TeamName = "Terrapins" },
                new Teams { TeamID = 4, TeamName = "Barracudas" },
                new Teams { TeamID = 5, TeamName = "Dolphins" },
                new Teams { TeamID = 6, TeamName = "Orcas" },
                new Teams { TeamID = 7, TeamName = "Manatees" },
                new Teams { TeamID = 8, TeamName = "Swordfish" },
                new Teams { TeamID = 9, TeamName = "Huckleberrys" },
                new Teams { TeamID = 10, TeamName = "MintJuleps" }
            );
        }
    }
}
