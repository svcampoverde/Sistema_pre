using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Datos.Models;
using System.Collections.Generic;
using System.Linq;

namespace Datos.Seeders
{
    public static class ProvinciaSeeder
    {
        public static void SeedProvincias(this EntityTypeBuilder<Provincia> modelBuilder)
        {
            modelBuilder.HasData(
              new Provincia { Id = 1, Nombre = "Azuay" },
              new Provincia { Id = 2, Nombre = "Bolívar" },
              new Provincia { Id = 3, Nombre = "Cañar" },
              new Provincia { Id = 4, Nombre = "Carchi" },
              new Provincia { Id = 5, Nombre = "Cotopaxi" },
              new Provincia { Id = 6, Nombre = "Chimborazo" },
              new Provincia { Id = 7, Nombre = "El Oro" },
              new Provincia { Id = 8, Nombre = "Esmeraldas" },
              new Provincia { Id = 9, Nombre = "Guayas" },
              new Provincia { Id = 10, Nombre = "Imbabura" },
              new Provincia { Id = 11, Nombre = "Loja" },
              new Provincia { Id = 12, Nombre = "Los Rios" },
              new Provincia { Id = 13, Nombre = "Manabi" },
              new Provincia { Id = 14, Nombre = "Morona Santiago" },
              new Provincia { Id = 15, Nombre = "Napo" },
              new Provincia { Id = 16, Nombre = "Pastaza" },
              new Provincia { Id = 17, Nombre = "Pichincha" },
              new Provincia { Id = 18, Nombre = "Tungurahua" },
              new Provincia { Id = 19, Nombre = "Zamora Chinchipe" },
              new Provincia { Id = 20, Nombre = "Galápagos" },
              new Provincia { Id = 21, Nombre = "Sucumbíos" },
              new Provincia { Id = 22, Nombre = "Orellana" },
              new Provincia { Id = 23, Nombre = "Santo Domingo de Los Tsáchilas" },
              new Provincia { Id = 24, Nombre = "Santa Elena" },
              new Provincia { Id = 25, Nombre = "Zonas No Delimitadas" });
        }
    }
}
