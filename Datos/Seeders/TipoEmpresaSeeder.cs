using Datos.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Datos.Seeders
{
    public static class TipoEmpresaSeeder
    {
        public static void SeedTipoEmpresa(this EntityTypeBuilder<TipoEmpresa> entity)
        {
            entity.HasData(
                new TipoEmpresa
                {
                    Id = 1,
                    Codigo = "SA",
                    Descripcion = "Sociedad Anónima",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoEmpresa
                {
                    Id = 2,
                    Codigo = "SRL",
                    Descripcion = "Sociedad de Responsabilidad Limitada",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoEmpresa
                {
                    Id = 3,
                    Codigo = "SC",
                    Descripcion = "Sociedad Colectiva",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoEmpresa
                {
                    Id = 4,
                    Codigo = "SC",
                    Descripcion = "Sociedad en Comandita",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoEmpresa
                {
                    Id = 5,
                    Codigo = "COOP",
                    Descripcion = "Cooperativa",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                }
            );
        }
    }
}
