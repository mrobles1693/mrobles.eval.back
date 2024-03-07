using entity;

namespace repository.Interfaces
{
    public interface IClienteRepository
    {
        Task<ClienteEntity> Insert(ClienteEntity cliente);
        Task<ClienteEntity?> GetByTipoNroDoc(int nIdTipoDocumento, string sDocumento);
    }
}
