using entity;

namespace repository.Interfaces
{
    public interface IPeliculaRepository
    {
        Task<PeliculaEntity?> GetById(int nIdPelicula);
    }
}
