﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity
{
    public class GeneroEntiy
    {
        [Key]
        public int nIdGenero { get; set; }
        public string sGenero { get; set; }
    }
}