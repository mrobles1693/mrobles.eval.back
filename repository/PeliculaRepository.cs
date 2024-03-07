using entity;
using Microsoft.EntityFrameworkCore;
using repository.Interfaces;

namespace repository
{
    public class PeliculaRepository : IPeliculaRepository
    {
        private readonly BackContext _context;

        public PeliculaRepository(BackContext context)
        {
            _context = context;
        }

        public async Task<PeliculaEntity?> GetById(int nIdPelicula)
        {
            return await _context.Pelicula
                .Include(p => p.generoPelicula)
                .FirstOrDefaultAsync(p => p.nIdPelicula == nIdPelicula);
        }
    }
}
