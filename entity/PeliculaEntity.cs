using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entity
{
    public class PeliculaEntity
    {
        [Key]
        public int nIdPelicula { get; set; }
        public string sTitulo { get; set; }
        public string sSinopsis { get; set; }
        public TimeSpan tDuracion { get; set; }
        public byte[]? bPortada { get; set; }

        [ForeignKey("generoPelicula")]
        public int nIdGenero { get; set; }
        public GeneroPeliculaEntity generoPelicula { get; set; }
    }
}
