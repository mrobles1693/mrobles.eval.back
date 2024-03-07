
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class ReservaEntity
    {
        [Key]
        public int nIdReserva { get; set; }

        [ForeignKey("nIdCliente")]
        public ClienteEntity cliente{ get; set; }

        [ForeignKey("nIdSalaPelicula")]
        public SalaPeliculaEntity salaPelicula { get; set; }

        public int nCantidad { get; set; }
    }
}