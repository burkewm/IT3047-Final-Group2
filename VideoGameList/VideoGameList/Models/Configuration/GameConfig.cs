using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace VideoGameList.Models
{
    internal class GameConfig : IEntityTypeConfiguration<VideoGame>
    {
        public void Configure(EntityTypeBuilder<VideoGame> entity)
        {
            entity.HasData(
                new VideoGame
                {
                    VideoGameId = 1,
                    Title = "Tom Clancy's The Division 2",
                    ESRBId = "M",
                    Genre = "Action RPG",
                    ReleaseDate = new DateTime(2019, 3, 15),
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
        }

    }
}
