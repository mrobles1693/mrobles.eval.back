using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Seeds
{
    public class TipoDocumentoSeed : IEntityTypeConfiguration<TipoDocumentoEntity>
    {
        public void Configure(EntityTypeBuilder<TipoDocumentoEntity> builder)
        {
            builder.HasData(
                new TipoDocumentoEntity() { nIdTipoDocumento = 1, sTipoDocumento = "DNI" },
                new TipoDocumentoEntity() { nIdTipoDocumento = 2, sTipoDocumento = "CE" },
                new TipoDocumentoEntity() { nIdTipoDocumento = 3, sTipoDocumento = "RUC" }
            );
        }
    }
}
