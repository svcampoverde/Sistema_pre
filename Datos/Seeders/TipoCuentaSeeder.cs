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
                    Descripcion = "Cuentas de Ahorros",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoCuenta
                {
                    Id = 2,
                    Codigo = "CC",
                    Descripcion = "Cuentas Corriente",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoCuenta
                {
                    Id = 3,
                    Codigo = "PF",
                    Descripcion = "Cuentas a Plazo Fijo",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoCuenta
                {
                    Id = 4,
                    Codigo = "MM",
                    Descripcion = "Cuentas de Mercado Monetario",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoCuenta
                {
                    Id = 5,
                    Codigo = "IP",
                    Descripcion = "Cuentas de Inversión Personal",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                }
            );
        }
    }
}
