using entity;
using Microsoft.EntityFrameworkCore;
using repository.Interfaces;

namespace repository
{
    public class SalaRepository : ISalaRepository
    {
        private readonly BackContext _context;

        public SalaRepository(BackContext context)
        {
            _context = context;    
        }

        public async Task<List<SalaEntity>> GetListSala()
        {
            return await _context.Sala.ToListAsync();
        }
    }
}
