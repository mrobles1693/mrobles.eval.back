using entity;
using Microsoft.EntityFrameworkCore;
using repository.Interfaces;

namespace repository
{
    public class SalaPeliculaRepository : ISalaPeliculaRepository
    {
        private readonly BackContext _context;

        public SalaPeliculaRepository(BackContext context)
        {
            _context = context;
        }

        public async Task<List<SalaPeliculaEntity>> GetListPeliculasByFilters(int? nIdSala, int? nIdGenero, string? sTitulo, DateTime? dFechaHoraInicio) 
        {
            var res = _context.SalaPelicula
                .Include(sp => sp.sala)
                .Include(sp => sp.pelicula)
                .Include(sp => sp.pelicula.generoPelicula).AsQueryable();

            if(nIdSala != null) 
            {
                res = res.Where(sp => sp.nIdSala == nIdSala);
            }

            if (nIdGenero != null)
            {
                res = res.Where(sp => sp.pelicula.nIdGenero == nIdGenero);
            }

            if (!String.IsNullOrEmpty(sTitulo))
            {
                res = res.Where(sp => sp.pelicula.sTitulo.Contains(sTitulo));
            }

            if(dFechaHoraInicio != null)
            {
                res = res.Where(sp => sp.dFechaProgramada > dFechaHoraInicio);
            }

            return res.ToList();
        }
    }
}
