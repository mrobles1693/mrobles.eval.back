﻿using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Interfaces
{
    public interface ITipoDocumentoRepository
    {
        Task<List<TipoDocumentoEntity>> GetListTipoDocumento();
    }
}
