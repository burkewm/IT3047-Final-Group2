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
            modelBuilder.ApplyConfiguration(new GameConfig());
            modelBuilder.ApplyConfiguration(new ESRBConfig());            
        }
    }
}
