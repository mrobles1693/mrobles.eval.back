using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Interfaces
{
    public interface IPeliculaRepository
    {
        Task<PeliculaEntity> Insert(PeliculaEntity pelicula);
        Task<PeliculaEntity?> GetById(int nIdPelicula);
    }
}
