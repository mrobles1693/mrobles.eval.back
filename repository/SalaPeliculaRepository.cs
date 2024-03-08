using entity;
using entity.DTO;
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

        public async Task<List<SalaPeliculaEntity>> GetListPeliculasByFilters(SalaPeliculaFilterDTO filtros) 
        {
            var res = _context.SalaPelicula
                .Include(sp => sp.sala)
                .Include(sp => sp.pelicula)
                .Include(sp => sp.pelicula.generoPelicula)
                .AsQueryable();

            if(filtros.nIdSala != null) 
            {
                res = res.Where(sp => sp.nIdSala == filtros.nIdSala);
            }

            if (filtros.nIdGenero != null)
            {
                res = res.Where(sp => sp.pelicula.nIdGenero == filtros.nIdGenero);
            }

            if (!String.IsNullOrEmpty(filtros.sTitulo))
            {
                res = res.Where(sp => sp.pelicula.sTitulo.Contains(filtros.sTitulo));
            }

            if (filtros.dFechaHoraInicio == null || filtros.dFechaHoraInicio < DateTime.Now)
            {
                res = res.Where(sp => sp.dFechaProgramada > DateTime.Now && sp.dFechaProgramada.Date == DateTime.Now.Date);
            }

            if (filtros.dFechaHoraInicio != null)
            {
                res = res.Where(sp => sp.dFechaProgramada > DateTime.Now && sp.dFechaProgramada.Date == ((DateTime)filtros.dFechaHoraInicio).Date);
            }

            res = res.Select(sp => new SalaPeliculaEntity { 
                nIdSalaPelicula = sp.nIdSalaPelicula,
                nIdSala = sp.nIdSala,
                nIdPelicula = sp.nIdPelicula,
                sala = sp.sala,
                pelicula = sp.pelicula,
                dFechaProgramada = sp.dFechaProgramada,
                nCantidadDisponible = sp.sala.nCapacidad - ( _context.Reserva.Where(r => r.nIdSalaPelicula == sp.nIdSalaPelicula).Sum(r => r.nCantidad) )
            });

            return await res.ToListAsync();
        }
    }
}
