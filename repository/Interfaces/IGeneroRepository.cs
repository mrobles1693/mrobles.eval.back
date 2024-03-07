using entity;

namespace repository.Interfaces
{
    public interface IGeneroRepository
    {
        Task<List<GeneroEntity>> GetListGenero();
    }
}
