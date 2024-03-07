using entity;

namespace repository.Interfaces
{
    public interface IGeneroPeliculaRepository
    {
        Task<List<GeneroPeliculaEntity>> GetListGeneroPelicula();
    }
}
