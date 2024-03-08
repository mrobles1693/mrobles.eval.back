using entity;
using entity.DTO;

namespace repository.Interfaces
{
    public interface IClienteRepository
    {
        Task<ClienteEntity> Insert(ClienteDTO cliente);
        Task<ClienteEntity?> GetByTipoNroDoc(int nIdTipoDocumento, string sDocumento);
    }
}
