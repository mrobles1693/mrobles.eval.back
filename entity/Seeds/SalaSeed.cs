using entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace entity.Seeds
{
    public class SalaSeed : IEntityTypeConfiguration<SalaEntity>
    {
        public void Configure(EntityTypeBuilder<SalaEntity> builder)
        {
            builder.HasData(
                new SalaEntity() { nIdSala = 1, sSala = "A", nCapacidad = 100 },
                new SalaEntity() { nIdSala = 2, sSala = "B", nCapacidad = 100 },
                new SalaEntity() { nIdSala = 3, sSala = "C", nCapacidad = 100 },
                new SalaEntity() { nIdSala = 4, sSala = "D", nCapacidad = 100 }
            );
        }
    }
}
