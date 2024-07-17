using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("productos"); // Nombre de la tabla en la base de datos

            builder.HasKey(e => e.Id); // Definición de la clave primaria

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); // Configuración de la columna Id

            builder.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasColumnType("VARCHAR(200)")
                .IsRequired(); // Configuración de la columna Descripcion

            builder.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .IsRequired(); // Configuración de la columna Descripcion

            builder.Property(e => e.Precio)
                .HasColumnName("precio")
                .HasColumnType("float")
                .IsRequired(); // Configuración de la columna Precio

            builder.Property(e => e.IdCategoriaProducto)
                .HasColumnName("idCategoriaProducto")
                .HasColumnType("int")
                .IsRequired(); // Configuración de la columna IdCategoriaProducto

            builder.Property(e => e.IdTipoProducto)
                .HasColumnName("idTipoProducto")
                .HasColumnType("int"); // Configuración de la columna IdTipoProducto (nullable)
            builder.Property(e => e.Activo)
     .HasColumnName("activo")
     .HasColumnType("bit")
     .IsRequired();
            builder.Property(e => e.FechaCreacionUTC)
                           .HasColumnName("fecha_creacion_utc")
                           .HasColumnType("datetime")
                           .IsRequired();
            builder.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime").IsRequired(false);
            builder.HasQueryFilter(e => e.Activo);
            // Relación uno a muchos con PresupuestoDetalle
            builder.HasMany(e => e.PresupuestoDetalles)
                .WithOne(p => p.IdproductoNavigation)
                .HasForeignKey(e => e.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("producto_presupuestodetalle_fk_producto"); // Relación con PresupuestoDetalle, configuración de la clave externa

            // Relación muchos a uno con CategoriaProducto
            builder.HasOne(e => e.CategoriaProducto)
                .WithMany(cp => cp.Productos)
                .HasForeignKey(e => e.IdCategoriaProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("producto_categoria_producto_fk"); // Relación con CategoriaProducto, configuración de la clave externa

            // Relación muchos a uno con TipoProducto (opcional)
            builder.HasOne(e => e.TipoProducto)
                .WithMany(tp => tp.Productos)
                .HasForeignKey(e => e.IdTipoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("producto_tipo_producto_fk"); // Relación con TipoProducto, configuración de la clave externa (opcional)

            // Llamada a método parcial para configuración adicional
            OnConfigurePartial(builder);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Producto> entity);
    }
}