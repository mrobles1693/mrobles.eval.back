
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class ReservaEntity
    {
        [Key]
        public int nIdReserva { get; set; }

        [ForeignKey("cliente")]
        public int nIdCliente { get; set; }
        public ClienteEntity cliente{ get; set; }

        [ForeignKey("salaPelicula")]
        public int nIdSalaPelicula { get; set; }
        public SalaPeliculaEntity salaPelicula { get; set; }

        public int nCantidad { get; set; }
    }
}