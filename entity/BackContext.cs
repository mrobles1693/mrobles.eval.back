using Microsoft.EntityFrameworkCore;
using entity.Seeds;

namespace entity
{
    public class BackContext : DbContext
    {
        public BackContext(DbContextOptions<BackContext> options) : base(options) { }

        public DbSet<GeneroEntiy> Genero{ get; set; }
        public DbSet<PeliculaEntity> Pelicula { get; set; }
        public DbSet<SalaEntity> Sala{ get; set; }
        public DbSet<SalaPeliculaEntity> SalaPelicula { get; set; }
        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<ReservaEntity> Reserva { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GeneroSeed());
            modelBuilder.ApplyConfiguration(new SalaSeed());
            modelBuilder.ApplyConfiguration(new PeliculaSeed());
            modelBuilder.ApplyConfiguration(new SalaPeliculaSeed());
        }
    }
}
