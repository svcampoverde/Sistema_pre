using Datos.Models;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;

namespace Datos.Seeders
{
    public static class CategoriaBancoSeeder
    {
        public static void SeedCategoriaBancos(this EntityTypeBuilder<CategoriaBanco> builder)
        {
            builder.HasData(
                new CategoriaBanco
                {
                    Id = 1,
                    Codigo = "PRIVN",
                    Nombre = "BANCOS PRIVADOS NACIONALES",
                    Descripcion = "Bancos privados nacionales",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow
                },
                new CategoriaBanco
                {
                    Id = 2,
                    Codigo = "PUB",
                    Nombre = "CASAS DE CAMBIO",
                    Descripcion = "Banco público",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow
                },
                new CategoriaBanco
                {
                    Id = 3,
                    Codigo = "MICRO",
                    Nombre = "COMPAÑIAS DE TITULARIZACION",
                    Descripcion = "Banco de microfinanzas",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow
                },
                new CategoriaBanco
                {
                    Id = 4,
                    Codigo = "SAVINGS",
                    Nombre = "BANCOS PRIVADOS EXTRANJEROS",
                    Descripcion = "Banco enfocado en cuentas de ahorro",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow
                },
                new CategoriaBanco
                {
                    Id = 5,
                    Codigo = "COMM",
                    Nombre = "BANCOS OFF SHORE",
                    Descripcion = "Banco que ofrece una gama completa de servicios financieros",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow
                },
                new CategoriaBanco
                {
                    Id = 6,
                    Codigo = "COOP",
                    Nombre = "OFIC. REPRESENTACION BANCOS EXTRANJEROS",
                    Descripcion = "Banco que opera bajo una estructura cooperativa",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow
                },
                new CategoriaBanco
                {
                    Id = 7,
                    Codigo = "COOP",
                    Nombre = "BUROS DE INFORMACION CREDITICIA",
                    Descripcion = "Banco que opera bajo una estructura cooperativa",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow
                },
                new CategoriaBanco
                {
                    Id = 8,
                    Codigo = "AGN",
                    Nombre = "AGENCIA DE BANCO NACIONAL EN EL EXTERIOR",
                    Descripcion = "Agencia que opera bajo la estructura de agencia",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow
                },
                new CategoriaBanco
                {
                    Id = 9,
                    Codigo = "AGD",
                    Nombre = "ALMACENES GENERALES DE DEPOSITOS",
                    Descripcion = "ALMACENES GENERALES DE DEPOSITOS",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow
                }
            );
        }
    }
}
