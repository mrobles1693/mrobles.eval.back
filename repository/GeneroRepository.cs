using entity;
using Microsoft.EntityFrameworkCore;
using repository.Interfaces;

namespace repository
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly BackContext _context;

        public GeneroRepository(BackContext context)
        {
            _context = context;
        }

        public async Task<List<GeneroEntity>> GetListGenero()
        {
            return await _context.Genero.ToListAsync();
        }
    }
}
