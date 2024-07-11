using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class AtributoProductoConfiguration : IEntityTypeConfiguration<AtributoProducto>
    {
        public void Configure(EntityTypeBuilder<AtributoProducto> entity)
        {
            entity.ToTable("atributos_producto"); // Nombre de la tabla en la base de datos

            entity.HasKey(e => e.Id); // Definición de la clave primaria

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); // Configuración de la columna Id

            entity.Property(e => e.IdProducto)
                .HasColumnName("fk_producto")
                .HasColumnType("int")
                .IsRequired(); // Configuración de la columna IdProducto

            entity.Property(e => e.IdAtributo)
                .HasColumnName("fk_atributo")
                .HasColumnType("int")
                .IsRequired(); // Configuración de la columna IdAtributo

            entity.Property(e => e.Valor)
                .HasColumnName("valor")
                .HasColumnType("VARCHAR(200)")
                .IsRequired(); // Configuración de la columna Valor
              entity.Property(e => e.Activo)
                .HasColumnName("activo")
                .HasColumnType("bit")
                .IsRequired();
            // Query Filter para propiedades activas
            entity.HasQueryFilter(e => e.Activo);
            entity.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime");

            // Relación muchos a uno con Producto
            entity.HasOne(e => e.Producto)
                .WithMany(p => p.AtributosProductos)
                .HasForeignKey(e => e.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("atributo_producto_fk_producto"); // Relación con Producto, configuración de la clave externa

            // Relación muchos a uno con Atributo
            entity.HasOne(e => e.Atributo)
                .WithMany(a => a.AtributosProductos)
                .HasForeignKey(e => e.IdAtributo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("atributo_producto_fk_atributo"); // Relación con Atributo, configuración de la clave externa

            // Llamada a método parcial para configuración adicional
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<AtributoProducto> entity);
    }
}
