using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class ClienteEntity
    {
        [Key]
        public int nIdCliente { get; set; }
        public int nIdTipoDocumento { get; set; }
        public string sDocumento { get; set; }
        public string sNombre { get; set; }
        public string sApellidoP { get; set; }
        public string sApellidoM { get; set; }
        public DateTime dFechaNacimiento { get; set; }
        public int nIdGenero { get; set; }
    }
}
