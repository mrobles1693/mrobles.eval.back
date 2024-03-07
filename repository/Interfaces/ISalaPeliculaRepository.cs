using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Interfaces
{
    public interface ISalaPeliculaRepository
    {
        Task<List<SalaPeliculaEntity>> GetListPeliculasByFilters(int? nIdSala, int? nIdGenero, string? sTitulo, DateTime? dFechaHoraInicio);
    }
}
