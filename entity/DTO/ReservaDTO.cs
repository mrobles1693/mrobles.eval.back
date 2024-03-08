using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.DTO
{
    public class ReservaDTO
    {
        public int nIdCliente { get; set; }
        public int nIdSalaPelicula { get; set; }
        public int nCantidad { get; set; }
    }
}
