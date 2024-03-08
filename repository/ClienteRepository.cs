using entity;
using entity.DTO;
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

        public async Task<ClienteEntity> Insert(ClienteDTO cliente)
        {
            EntityEntry<ClienteEntity> insert = await _context.Cliente
                .AddAsync(new ClienteEntity() { 
                    nIdTipoDocumento = cliente.nIdTipoDocumento
                    ,sDocumento = cliente.sDocumento
                    ,sApellidoP = cliente.sApellidoP
                    ,sApellidoM = cliente.sApellidoM
                    ,sNombre = cliente.sNombre
                    ,dFechaNacimiento = cliente.dFechaNacimiento
                    ,nIdGenero = cliente.nIdGenero
                });
            await _context.SaveChangesAsync();
            return insert.Entity;
        }
    }
}
