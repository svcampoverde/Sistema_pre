using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Datos.Seeders
{
    public static class CategoriaProductoSeeder
    {
        public static void SeedCategoriaProducto(this EntityTypeBuilder<CategoriaProducto> entity)
        {
            entity.HasData(
                new CategoriaProducto { Id = 1, Codigo = "ELECT", Descripcion = "Electrónicos", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new CategoriaProducto { Id = 2, Codigo = "HOME_APPL", Descripcion = "Electrodomésticos", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new CategoriaProducto { Id = 3, Codigo = "APPAREL", Descripcion = "Ropa y calzado", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new CategoriaProducto { Id = 4, Codigo = "BEAUTY", Descripcion = "Belleza y cuidado personal", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new CategoriaProducto { Id = 5, Codigo = "SPORTS", Descripcion = "Deportes y aire libre", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new CategoriaProducto { Id = 6, Codigo = "TOYS", Descripcion = "Juguetes y juegos", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new CategoriaProducto { Id = 7, Codigo = "BOOKS", Descripcion = "Libros y audiolibros", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new CategoriaProducto { Id = 8, Codigo = "GROCERY", Descripcion = "Abarrotes y supermercado", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new CategoriaProducto { Id = 9, Codigo = "AUTOMOTIVE", Descripcion = "Automotriz", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new CategoriaProducto { Id = 10, Codigo = "PET_SUPPLIES", Descripcion = "Suministros para mascotas", Activo = true, FechaCreacionUTC = DateTime.UtcNow }

            );
        }
    }
}
