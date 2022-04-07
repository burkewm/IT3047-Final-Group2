using System;
using Microsoft.EntityFrameworkCore;

namespace VideoGameList.Models
{
    public class VideoGameContext : DbContext
    {
        public VideoGameContext(DbContextOptions<VideoGameContext> options)
            : base(options)
        { }

        public DbSet<VideoGame> Games { get; set; }
        public DbSet<ESRB> ESRB { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame
                {
                    VideoGameId = 1,
                    Title = "Tom Clancy's The Division 2",
                    ESRBId = "M",
                    Genre = "Action RPG",
                    ReleaseDate = new DateTime(2019,3,15),
                    Rating = 5
                },
                new VideoGame
                {
                    VideoGameId = 2,
                    Title = "Grand Theft Auto V",
                    ESRBId = "M",
                    Genre = "Action Adventure",
                    ReleaseDate = new DateTime(2013, 9, 17),
                    Rating = 5
                }
            );
            modelBuilder.Entity<ESRB>().HasData(
                new ESRB { ESRBId = "E", Name = "Everyone" },
                new ESRB { ESRBId = "E 10+", Name = "Everyone 10+" },
                new ESRB { ESRBId = "T", Name = "Teen" },
                new ESRB { ESRBId = "M", Name = "Mature" },
                new ESRB { ESRBId = "A", Name = "Adults" },
                new ESRB { ESRBId = "RP", Name = "Rating Pending" }
            );
        }
    }
}
