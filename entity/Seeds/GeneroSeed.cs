using entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entity.Seeds
{
    public class GeneroSeed : IEntityTypeConfiguration<GeneroEntiy>
    {
        public void Configure(EntityTypeBuilder<GeneroEntiy> builder) 
        {
            builder.HasData(
                new GeneroEntiy() { nIdGenero = 1, sGenero = "Acción"},    
                new GeneroEntiy() { nIdGenero = 2, sGenero = "Terror" },
                new GeneroEntiy() { nIdGenero = 3, sGenero = "Comedia" }
            );
        }
    }
}
