using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> entity)
        {
            // Especifica el nombre de la tabla
            entity.ToTable("inventario");

            // Llave primaria
            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            // Configuración de columnas de Inventario
            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd();

            entity.Property(e => e.IdProducto)
                .HasColumnName("idProducto")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.Cantidad)
                .HasColumnName("cantidad")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.Ubicacion)
                .HasColumnName("ubicacion")
                .HasColumnType("VARCHAR(500)");

            entity.Property(e => e.PrecioCompra)
                .HasColumnName("precio_compra")
                .HasColumnType("decimal(18, 2)")
                .IsRequired();

            entity.Property(e => e.PrecioVenta)
                .HasColumnName("precio_venta")
                .HasColumnType("decimal(18, 2)")
                .IsRequired();

            entity.Property(e => e.Activo)
                         .HasColumnName("activo")
                         .HasColumnType("bit")
                         .IsRequired();
            entity.HasQueryFilter(e => e.Activo);
            entity.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime");

            // Configuración de relación con Producto
            entity.HasOne(e => e.Producto)
                .WithOne(p => p.Inventario)
                .HasForeignKey<Inventario>(i => i.IdProducto)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("inventario_producto_fk");
        }
    }
}
