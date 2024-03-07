using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Seeds
{
    public class GeneroSeed : IEntityTypeConfiguration<GeneroEntity>
    {
        public void Configure(EntityTypeBuilder<GeneroEntity> builder)
        {
            builder.HasData(
                new GeneroEntity() { nIdGenero = 1, sGenero = "Masculino" },
                new GeneroEntity() { nIdGenero = 2, sGenero = "Femenino" }
            );
        }
    }
}
