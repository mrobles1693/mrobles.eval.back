using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.DTO
{
    public class SalaPeliculaFilterDTO
    {
        public int? nIdSala { get; set; }
        public int? nIdGenero { get; set; }
        public string? sTitulo { get; set; }
        public DateTime? dFechaHoraInicio { get; set; }
    }
}
