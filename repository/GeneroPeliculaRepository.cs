using entity;
using Microsoft.EntityFrameworkCore;
using repository.Interfaces;

namespace repository
{
    public class GeneroPeliculaRepository : IGeneroPeliculaRepository
    {
        private readonly BackContext _context;

        public GeneroPeliculaRepository(BackContext context)
        {
            _context = context;
        }

        public async Task<List<GeneroPeliculaEntity>> GetListGeneroPelicula()
        {
            return await _context.GeneroPelicula.ToListAsync();
        }
    }
}
