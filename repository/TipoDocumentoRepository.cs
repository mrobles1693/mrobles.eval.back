using entity;
using Microsoft.EntityFrameworkCore;
using repository.Interfaces;

namespace repository
{
    public class TipoDocumentoRepository : ITipoDocumentoRepository
    {
        private readonly BackContext _context;

        public TipoDocumentoRepository(BackContext context)
        {
            _context = context;
        }

        public async Task<List<TipoDocumentoEntity>> GetListTipoDocumento()
        {
            return await _context.TipoDocumento.ToListAsync();
        }
    }
}
