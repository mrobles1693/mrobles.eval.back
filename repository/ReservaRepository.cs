using entity;
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

        public async Task<ReservaEntity> Insert(ReservaEntity cliente)
        {
            EntityEntry<ReservaEntity> insert = await _context.Reserva.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return insert.Entity;
        }
    }
}
