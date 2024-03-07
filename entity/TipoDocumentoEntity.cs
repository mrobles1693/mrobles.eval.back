using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class TipoDocumentoEntity
    {
        [Key]
        public int nIdTipoDocumento { get; set; }
        public string sTipoDocumento { get; set; }
    }
}
