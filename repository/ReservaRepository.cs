using entity;
using entity.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using repository.Interfaces;

namespace repository
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly BackContext _context;

        public ReservaRepository(BackContext context)
        {
            _context = context;
        }

        public async Task<ReservaEntity> Insert(ReservaDTO reserva)
        {
            EntityEntry<ReservaEntity> insert = await _context.Reserva
                .AddAsync(new ReservaEntity() { 
                    nIdCliente = reserva.nIdCliente,
                    nIdSalaPelicula = reserva.nIdSalaPelicula,
                    nCantidad = reserva.nCantidad
                });
            await _context.SaveChangesAsync();
            return insert.Entity;
        }

        public async Task<ReservaEntity?> GetById(int nIdReserva)
        {
            return await _context.Reserva
                .Include(r => r.cliente)
                .Include(r => r.cliente.genero)
                .Include(r => r.cliente.tipoDocumento)
                .Include(r => r.salaPelicula)
                .Include(r => r.salaPelicula.sala)
                .Include(r => r.salaPelicula.pelicula)
                .Include(r => r.salaPelicula.pelicula.generoPelicula)
                .FirstOrDefaultAsync(r => r.nIdReserva == nIdReserva);
        }
    }
}
