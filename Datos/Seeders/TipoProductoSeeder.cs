using Datos.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Datos.Seeders
{
    public static class TipoProductoSeeder
    {
        public static void SeedTipoProducto(this EntityTypeBuilder<TipoProducto> entity)
        {
            entity.HasData(
                new TipoProducto { Id = 1, Codigo = "SMARTPHONE", Nombre = "Smartphone", Descripcion = "Smartphone", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 2, Codigo = "LAPTOP", Nombre = "Laptop", Descripcion = "Laptop", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 3, Codigo = "TABLET", Nombre = "Tablet", Descripcion = "Tablet", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 4, Codigo = "SMARTWATCH", Nombre = "Smartwatch", Descripcion = "Smartwatch", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 5, Codigo = "TV", Nombre = "TV", Descripcion = "TV", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 6, Codigo = "CAMERA", Nombre = "Cámara Fotográfica", Descripcion = "Cámara Fotográfica", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 7, Codigo = "HEADPHONES", Nombre = "Audífonos", Descripcion = "Audífonos", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 8, Codigo = "PRINTER", Nombre = "Impresora", Descripcion = "Impresora", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 9, Codigo = "MONITOR", Nombre = "Monitor", Descripcion = "Monitor", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 10, Codigo = "ROUTER", Nombre = "Router", Descripcion = "Router", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 11, Codigo = "MICROWAVE", Nombre = "Microondas", Descripcion = "Microondas", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 12, Codigo = "FRIDGE", Nombre = "Refrigerador", Descripcion = "Refrigerador", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 13, Codigo = "WASHING_MACHINE", Nombre = "Lavadora", Descripcion = "Lavadora", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 14, Codigo = "DRYER", Nombre = "Secadora", Descripcion = "Secadora", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 15, Codigo = "BLENDER", Nombre = "Licuadora", Descripcion = "Licuadora", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 16, Codigo = "VACUUM_CLEANER", Nombre = "Aspiradora", Descripcion = "Aspiradora", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 17, Codigo = "COFFEE_MACHINE", Nombre = "Cafetera", Descripcion = "Cafetera", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 18, Codigo = "TOASTER", Nombre = "Tostadora", Descripcion = "Tostadora", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 19, Codigo = "IRON", Nombre = "Plancha", Descripcion = "Plancha", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 20, Codigo = "PROJECTOR", Nombre = "Proyector", Descripcion = "Proyector", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 31, Codigo = "FRUITS", Nombre = "Frutas", Descripcion = "Frutas", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 32, Codigo = "VEGETABLES", Nombre = "Verduras", Descripcion = "Verduras", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 33, Codigo = "DAIRY", Nombre = "Productos lácteos", Descripcion = "Productos lácteos", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 34, Codigo = "BAKERY", Nombre = "Panadería", Descripcion = "Panadería", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 35, Codigo = "MEAT", Nombre = "Carne y aves", Descripcion = "Carne y aves", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 36, Codigo = "SEAFOOD", Nombre = "Mariscos", Descripcion = "Mariscos", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 37, Codigo = "BEVERAGES", Nombre = "Bebidas", Descripcion = "Bebidas", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 38, Codigo = "SNACKS", Nombre = "Snacks y golosinas", Descripcion = "Snacks y golosinas", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 39, Codigo = "CONDIMENTS", Nombre = "Condimentos y salsas", Descripcion = "Condimentos y salsas", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 40, Codigo = "CANNED_FOODS", Nombre = "Alimentos enlatados", Descripcion = "Alimentos enlatados", Activo = true, FechaCreacionUTC = DateTime.UtcNow }
            );
        }
    }
}
