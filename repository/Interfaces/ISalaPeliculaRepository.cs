using entity;
using entity.DTO;

namespace repository.Interfaces
{
    public interface ISalaPeliculaRepository
    {
        Task<List<SalaPeliculaEntity>> GetListPeliculasByFilters(SalaPeliculaFilterDTO filtros);
    }
}
