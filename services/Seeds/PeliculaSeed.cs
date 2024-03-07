using entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace services.Seeds
{
    public class PeliculaSeed : IEntityTypeConfiguration<PeliculaEntity>
    {
        public void Configure(EntityTypeBuilder<PeliculaEntity> builder)
        {
            builder.HasData(
                new PeliculaEntity() { nIdPelicula = 1, sTitulo = "Terminator", tDuracion = new TimeSpan(1,30,00), sSinopsis = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", nIdGenero = 1, bPortada = null },
                new PeliculaEntity() { nIdPelicula = 2, sTitulo = "Duro de Matar", tDuracion = new TimeSpan(1, 45, 00), sSinopsis = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", nIdGenero = 1, bPortada = null },
                new PeliculaEntity() { nIdPelicula = 3, sTitulo = "Saw I", tDuracion = new TimeSpan(2, 00, 00), sSinopsis = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", nIdGenero = 2, bPortada = null },
                new PeliculaEntity() { nIdPelicula = 4, sTitulo = "La Monja", tDuracion = new TimeSpan(1, 40, 00), sSinopsis = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", nIdGenero = 2, bPortada = null },
                new PeliculaEntity() { nIdPelicula = 5, sTitulo = "Donde están las tubias", tDuracion = new TimeSpan(1, 45, 00), sSinopsis = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", nIdGenero = 3, bPortada = null },
                new PeliculaEntity() { nIdPelicula = 6, sTitulo = "El todo poderoso", tDuracion = new TimeSpan(1, 35, 00), sSinopsis = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", nIdGenero = 3, bPortada = null }
            );
        }
    }
}
