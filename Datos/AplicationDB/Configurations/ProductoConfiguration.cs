using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> entity)
        {
            entity.ToTable("productos"); // Nombre de la tabla en la base de datos

            entity.HasKey(e => e.Id); // Definición de la clave primaria

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); // Configuración de la columna Id

            entity.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasColumnType("VARCHAR(200)")
                .IsRequired(); // Configuración de la columna Descripcion
            
            entity.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .IsRequired(); // Configuración de la columna Descripcion

            entity.Property(e => e.Precio)
                .HasColumnName("precio")
                .HasColumnType("float")
                .IsRequired(); // Configuración de la columna Precio

            entity.Property(e => e.IdCategoriaProducto)
                .HasColumnName("idCategoriaProducto")
                .HasColumnType("int")
                .IsRequired(); // Configuración de la columna IdCategoriaProducto

            entity.Property(e => e.IdTipoProducto)
                .HasColumnName("idTipoProducto")
                .HasColumnType("int"); // Configuración de la columna IdTipoProducto (nullable)

            // Relación uno a muchos con PresupuestoDetalle
            entity.HasMany(e => e.PresupuestoDetalles)
                .WithOne(p => p.IdproductoNavigation)
                .HasForeignKey(e => e.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("producto_presupuestodetalle_fk_producto"); // Relación con PresupuestoDetalle, configuración de la clave externa

            // Relación muchos a uno con CategoriaProducto
            entity.HasOne(e => e.CategoriaProducto)
                .WithMany(cp => cp.Productos)
                .HasForeignKey(e => e.IdCategoriaProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("producto_categoria_producto_fk"); // Relación con CategoriaProducto, configuración de la clave externa

            // Relación muchos a uno con TipoProducto (opcional)
            entity.HasOne(e => e.TipoProducto)
                .WithMany(tp => tp.Productos)
                .HasForeignKey(e => e.IdTipoProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("producto_tipo_producto_fk"); // Relación con TipoProducto, configuración de la clave externa (opcional)

            // Llamada a método parcial para configuración adicional
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Producto> entity);
    }
}
