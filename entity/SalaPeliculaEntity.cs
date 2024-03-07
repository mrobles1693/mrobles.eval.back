using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity
{
    public class SalaPeliculaEntity
    {
        [Key]
        public int nIdSalaPelicula { get; set; }
        
        [ForeignKey("sala")]
        public int nIdSala { get; set; }
        public SalaEntity sala { get; set; }

        [ForeignKey("pelicula")]
        public int nIdPelicula { get; set; }
        public PeliculaEntity pelicula { get; set; }
        
        public DateTime dFechaProgramada { get; set; }

        [NotMapped]
        public int nCantidadDisponible { get; set; }
    }
}
