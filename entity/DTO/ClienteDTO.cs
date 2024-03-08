using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.DTO
{
    public class ClienteDTO
    {
        public int nIdTipoDocumento { get; set; }
        public string sDocumento { get; set; }
        public string sNombre { get; set; }
        public string sApellidoP { get; set; }
        public string sApellidoM { get; set; }
        public DateTime dFechaNacimiento { get; set; }
        public int nIdGenero { get; set; }
    }
}
