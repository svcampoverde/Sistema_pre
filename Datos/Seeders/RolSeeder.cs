using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Seeders
{
    public static class RolSeeder
    {
        public static void SeedRol(this EntityTypeBuilder<Rol> modelBuilder)
        {
            modelBuilder.HasData(
                new Rol {Id=1,Codigo="ADM",  Descripcion = "Administrador", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol {Id=2, Codigo = "USEST", Descripcion = "Usuario Estándar", FechaCreacionUTC = DateTime.UtcNow, Activo = true }
            );
        }
    }
}
