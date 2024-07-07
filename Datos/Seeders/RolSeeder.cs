using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Datos.Seeders
{
    public static class RolSeeder
    {
        public static void SeedRol(this EntityTypeBuilder<Rol> modelBuilder)
        {
            modelBuilder.HasData(
                new Rol { Id = 1, Codigo = "ADM", Descripcion = "Administrador", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 2, Codigo = "USER", Descripcion = "Usuario Estándar", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 3, Codigo = "SUP", Descripcion = "Supervisor", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 4, Codigo = "MNGR", Descripcion = "Gerente", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 5, Codigo = "HR", Descripcion = "Recursos Humanos", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 6, Codigo = "ACCT", Descripcion = "Contador", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 7, Codigo = "SALES", Descripcion = "Ventas", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 8, Codigo = "IT", Descripcion = "Tecnología de la Información", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 9, Codigo = "SUPPORT", Descripcion = "Soporte Técnico", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 10, Codigo = "ANALYST", Descripcion = "Analista", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 11, Codigo = "PROJMAN", Descripcion = "Gerente de Proyecto", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 12, Codigo = "MARKET", Descripcion = "Marketing", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 13, Codigo = "CUSTSERV", Descripcion = "Servicio al Cliente", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 14, Codigo = "DEV", Descripcion = "Desarrollador", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 15, Codigo = "QA", Descripcion = "Aseguramiento de Calidad", FechaCreacionUTC = DateTime.UtcNow, Activo = true }
            );
        }
    }
}
