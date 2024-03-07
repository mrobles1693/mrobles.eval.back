using entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entity.Seeds
{
    public class GeneroPeliculaSeed : IEntityTypeConfiguration<GeneroPeliculaEntity>
    {
        public void Configure(EntityTypeBuilder<GeneroPeliculaEntity> builder) 
        {
            builder.HasData(
                new GeneroPeliculaEntity() { nIdGenero = 1, sGenero = "Acción"},    
                new GeneroPeliculaEntity() { nIdGenero = 2, sGenero = "Terror" },
                new GeneroPeliculaEntity() { nIdGenero = 3, sGenero = "Comedia" }
            );
        }
    }
}
