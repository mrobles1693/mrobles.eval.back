using entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using repository.Interfaces;

namespace repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly BackContext _context;

        public ClienteRepository(BackContext context)
        {
            _context = context;
        }

        public async Task<ClienteEntity?> GetByTipoNroDoc(int nIdTipoDocumento, string sDocumento)
        {
            return await _context.Cliente
                .Include(c => c.genero)
                .Include(c => c.tipoDocumento)
                .FirstOrDefaultAsync(c => c.nIdTipoDocumento == nIdTipoDocumento && c.sDocumento == sDocumento);
        }

        public async Task<ClienteEntity> Insert(ClienteEntity cliente)
        {
            EntityEntry<ClienteEntity> insert = await _context.Cliente.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return insert.Entity;
        }
    }
}
