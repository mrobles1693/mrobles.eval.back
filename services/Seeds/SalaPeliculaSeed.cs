using entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace services.Seeds
{
    public class SalaPeliculaSeed : IEntityTypeConfiguration<SalaPeliculaEntity>
    {
        public void Configure(EntityTypeBuilder<SalaPeliculaEntity> builder)
        {
            builder.HasData(
                new SalaPeliculaEntity() { nIdSalaPelicula = 1, dFechaProgramada = new DateTime(2024, 03, 08, 16, 00, 0), nIdSala = 1, nIdPelicula = 1 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 2, dFechaProgramada = new DateTime(2024, 03, 08, 15, 00, 0), nIdSala = 2, nIdPelicula = 2 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 3, dFechaProgramada = new DateTime(2024, 03, 08, 18, 30, 0), nIdSala = 1, nIdPelicula = 3 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 4, dFechaProgramada = new DateTime(2024, 03, 08, 17, 30, 0), nIdSala = 2, nIdPelicula = 4 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 5, dFechaProgramada = new DateTime(2024, 03, 08, 21, 00, 0), nIdSala = 1, nIdPelicula = 5 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 6, dFechaProgramada = new DateTime(2024, 03, 08, 20, 00, 0), nIdSala = 2, nIdPelicula = 6 },

                new SalaPeliculaEntity() { nIdSalaPelicula = 7, dFechaProgramada = new DateTime(2024, 03, 09, 16, 00, 0), nIdSala = 1, nIdPelicula = 1 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 8, dFechaProgramada = new DateTime(2024, 03, 09, 15, 00, 0), nIdSala = 2, nIdPelicula = 2 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 9, dFechaProgramada = new DateTime(2024, 03, 09, 18, 30, 0), nIdSala = 1, nIdPelicula = 3 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 10, dFechaProgramada = new DateTime(2024, 03, 09, 17, 30, 0), nIdSala = 2, nIdPelicula = 4 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 11, dFechaProgramada = new DateTime(2024, 03, 09, 21, 00, 0), nIdSala = 1, nIdPelicula = 5 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 12, dFechaProgramada = new DateTime(2024, 03, 09, 20, 00, 0), nIdSala = 2, nIdPelicula = 6 },

                new SalaPeliculaEntity() { nIdSalaPelicula = 13, dFechaProgramada = new DateTime(2024, 03, 10, 16, 00, 0), nIdSala = 1, nIdPelicula = 1 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 14, dFechaProgramada = new DateTime(2024, 03, 10, 15, 00, 0), nIdSala = 2, nIdPelicula = 2 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 15, dFechaProgramada = new DateTime(2024, 03, 10, 18, 30, 0), nIdSala = 1, nIdPelicula = 3 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 16, dFechaProgramada = new DateTime(2024, 03, 10, 17, 30, 0), nIdSala = 2, nIdPelicula = 4 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 17, dFechaProgramada = new DateTime(2024, 03, 10, 21, 00, 0), nIdSala = 1, nIdPelicula = 5 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 18, dFechaProgramada = new DateTime(2024, 03, 10, 20, 00, 0), nIdSala = 2, nIdPelicula = 6 },

                new SalaPeliculaEntity() { nIdSalaPelicula = 19, dFechaProgramada = new DateTime(2024, 03, 11, 16, 00, 0), nIdSala = 1, nIdPelicula = 1 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 20, dFechaProgramada = new DateTime(2024, 03, 11, 15, 00, 0), nIdSala = 2, nIdPelicula = 2 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 21, dFechaProgramada = new DateTime(2024, 03, 11, 18, 30, 0), nIdSala = 1, nIdPelicula = 3 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 22, dFechaProgramada = new DateTime(2024, 03, 11, 17, 30, 0), nIdSala = 2, nIdPelicula = 4 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 23, dFechaProgramada = new DateTime(2024, 03, 11, 21, 00, 0), nIdSala = 1, nIdPelicula = 5 },
                new SalaPeliculaEntity() { nIdSalaPelicula = 24, dFechaProgramada = new DateTime(2024, 03, 11, 20, 00, 0), nIdSala = 2, nIdPelicula = 6 }
            );
        }
    }
}
