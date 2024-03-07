using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity
{
    public class ClienteEntity
    {
        [Key]
        public int nIdCliente { get; set; }
        
        [ForeignKey("tipoDocumento")]
        public int nIdTipoDocumento { get; set; }
        public TipoDocumentoEntity tipoDocumento { get; set; }

        public string sDocumento { get; set; }
        public string sNombre { get; set; }
        public string sApellidoP { get; set; }
        public string sApellidoM { get; set; }
        public DateTime dFechaNacimiento { get; set; }
        
        [ForeignKey("genero")]
        public int nIdGenero { get; set; }
        public GeneroEntity genero { get; set; }
    }
}
