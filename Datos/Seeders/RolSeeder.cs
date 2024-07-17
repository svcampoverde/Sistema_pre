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
                new Rol { Id = 1, Codigo = "ADM", Nombre = "Administrador", Descripcion = "Administrador", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 2, Codigo = "USER", Nombre = "Usuario Estándar", Descripcion = "Usuario Estándar", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 3, Codigo = "SUP", Nombre = "Supervisor", Descripcion = "Supervisor", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 4, Codigo = "MNGR", Nombre = "Gerente", Descripcion = "Gerente", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 5, Codigo = "HR", Nombre = "Recursos Humanos", Descripcion = "Recursos Humanos", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 6, Codigo = "ACCT", Nombre = "Contador", Descripcion = "Contador", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 7, Codigo = "SALES", Nombre = "Ventas", Descripcion = "Ventas", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 8, Codigo = "IT", Nombre = "Tecnología de la Información", Descripcion = "Tecnología de la Información", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 9, Codigo = "SUPPORT", Nombre = "Soporte Técnico", Descripcion = "Soporte Técnico", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 10, Codigo = "ANALYST", Nombre = "Analista", Descripcion = "Analista", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 11, Codigo = "PROJMAN", Nombre = "Gerente de Proyecto", Descripcion = "Gerente de Proyecto", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 12, Codigo = "MARKET", Nombre = "Marketing", Descripcion = "Marketing", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 13, Codigo = "CUSTSERV", Nombre = "Servicio al Cliente", Descripcion = "Servicio al Cliente", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 14, Codigo = "DEV", Nombre = "Desarrollador", Descripcion = "Desarrollador", FechaCreacionUTC = DateTime.UtcNow, Activo = true },
                new Rol { Id = 15, Codigo = "QA", Nombre = "Aseguramiento de Calidad", Descripcion = "Aseguramiento de Calidad", FechaCreacionUTC = DateTime.UtcNow, Activo = true }
            );
        }
    }
}
