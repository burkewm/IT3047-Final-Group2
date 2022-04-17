using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VideoGameList.Models
{
    internal class ESRBConfig : IEntityTypeConfiguration<ESRB>
    {
        public void Configure(EntityTypeBuilder<ESRB> entity)
        {
            entity.HasData(
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
