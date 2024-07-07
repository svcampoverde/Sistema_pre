using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Datos.Seeders
{
    public static class TipoProductoSeeder
    {
        public static void SeedTipoProducto(this EntityTypeBuilder<TipoProducto> entity)
        {
            entity.HasData(
                new TipoProducto { Id = 1, Codigo = "SMARTPHONE", Descripcion = "Smartphone", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 2, Codigo = "LAPTOP", Descripcion = "Laptop", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 3, Codigo = "TABLET", Descripcion = "Tablet", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 4, Codigo = "SMARTWATCH", Descripcion = "Smartwatch", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 5, Codigo = "TV", Descripcion = "TV", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 6, Codigo = "CAMERA", Descripcion = "Cámara Fotográfica", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 7, Codigo = "HEADPHONES", Descripcion = "Audífonos", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 8, Codigo = "PRINTER", Descripcion = "Impresora", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 9, Codigo = "MONITOR", Descripcion = "Monitor", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 10, Codigo = "ROUTER", Descripcion = "Router", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 11, Codigo = "MICROWAVE", Descripcion = "Microondas", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 12, Codigo = "FRIDGE", Descripcion = "Refrigerador", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 13, Codigo = "WASHING_MACHINE", Descripcion = "Lavadora", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 14, Codigo = "DRYER", Descripcion = "Secadora", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 15, Codigo = "BLENDER", Descripcion = "Licuadora", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 16, Codigo = "VACUUM_CLEANER", Descripcion = "Aspiradora", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 17, Codigo = "COFFEE_MACHINE", Descripcion = "Cafetera", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 18, Codigo = "TOASTER", Descripcion = "Tostadora", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 19, Codigo = "IRON", Descripcion = "Plancha", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 20, Codigo = "PROJECTOR", Descripcion = "Proyector", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 31, Codigo = "FRUITS", Descripcion = "Frutas", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 32, Codigo = "VEGETABLES", Descripcion = "Verduras", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 33, Codigo = "DAIRY", Descripcion = "Productos lácteos", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 34, Codigo = "BAKERY", Descripcion = "Panadería", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 35, Codigo = "MEAT", Descripcion = "Carne y aves", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 36, Codigo = "SEAFOOD", Descripcion = "Mariscos", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 37, Codigo = "BEVERAGES", Descripcion = "Bebidas", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 38, Codigo = "SNACKS", Descripcion = "Snacks y golosinas", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 39, Codigo = "CONDIMENTS", Descripcion = "Condimentos y salsas", Activo = true, FechaCreacionUTC = DateTime.UtcNow },
                new TipoProducto { Id = 40, Codigo = "CANNED_FOODS", Descripcion = "Alimentos enlatados", Activo = true, FechaCreacionUTC = DateTime.UtcNow }
            );
        }
    }
}
