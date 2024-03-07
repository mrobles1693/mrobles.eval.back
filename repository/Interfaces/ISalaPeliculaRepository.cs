using entity;

namespace repository.Interfaces
{
    public interface ISalaPeliculaRepository
    {
        Task<List<SalaPeliculaEntity>> GetListPeliculasByFilters(int? nIdSala, int? nIdGenero, string? sTitulo, DateTime? dFechaHoraInicio);
    }
}
