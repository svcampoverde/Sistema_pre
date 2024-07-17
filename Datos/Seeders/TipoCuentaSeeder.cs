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
                    Nombre = "Cuentas de Ahorros",
                    Descripcion = "Cuentas de Ahorros",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoCuenta
                {
                    Id = 2,
                    Codigo = "CC",
                    Nombre = "Cuentas Corriente",
                    Descripcion = "Cuentas Corriente",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoCuenta
                {
                    Id = 3,
                    Codigo = "PF",
                    Nombre = "Cuentas a Plazo Fijo",
                    Descripcion = "Cuentas a Plazo Fijo",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoCuenta
                {
                    Id = 4,
                    Codigo = "MM",
                    Nombre = "Cuentas de Mercado Monetario",
                    Descripcion = "Cuentas de Mercado Monetario",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                },
                new TipoCuenta
                {
                    Id = 5,
                    Codigo = "IP",
                    Nombre = "Cuentas de Inversión Personal",
                    Descripcion = "Cuentas de Inversión Personal",
                    Activo = true,
                    FechaCreacionUTC = DateTime.UtcNow,
                    FechaModificacionUTC = DateTime.UtcNow
                }
            );
        }
    }
}
