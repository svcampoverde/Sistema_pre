using Datos.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Datos.Seeders
{
    public static class TipoCuentaSeeder
    {
        public static void SeedTipoCuenta(this EntityTypeBuilder<TipoCuenta> entity)
        {
            entity.HasData(
                new TipoCuenta
                {
                    Id = 1,
                    Codigo = "CA",
                    Descripcion = "Cuenta de Ahorros",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoCuenta
                {
                    Id = 2,
                    Codigo = "CC",
                    Descripcion = "Cuenta Corriente",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoCuenta
                {
                    Id = 3,
                    Codigo = "PF",
                    Descripcion = "Cuenta a Plazo Fijo",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoCuenta
                {
                    Id = 4,
                    Codigo = "MM",
                    Descripcion = "Cuenta de Mercado Monetario",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoCuenta
                {
                    Id = 5,
                    Codigo = "IP",
                    Descripcion = "Cuenta de Inversión Personal",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                }
            );
        }
    }
}
