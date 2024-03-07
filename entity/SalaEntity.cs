using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class SalaEntity
    {
        [Key]
        public int nIdSala { get; set; }
        public string sSala { get; set; }
        public int nCapacidad { get; set; }
    }
}
