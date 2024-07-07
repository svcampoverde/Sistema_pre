using Datos.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Seeders
{
    public static class TipoServicioSeeder
    {
        public static void SeedTipoServicio(this EntityTypeBuilder<TipoServicio> entity)
        {
            entity.HasData(
                new TipoServicio { Id = 1, Codigo = "CAMERINO", Descripcion = "Camerino", Activo = true, FechaCreacionUTC = DateTime.UtcNow }
                );

        }
    }
}
