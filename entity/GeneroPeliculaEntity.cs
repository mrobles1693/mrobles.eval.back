using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class GeneroPeliculaEntity
    {
        [Key]
        public int nIdGenero { get; set; }
        public string sGenero { get; set; }
    }
}
