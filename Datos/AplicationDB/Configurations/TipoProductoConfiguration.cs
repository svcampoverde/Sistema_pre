using Datos.Models;
using Datos.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public class TipoProductoConfiguration : IEntityTypeConfiguration<TipoProducto>
    {
        public void Configure(EntityTypeBuilder<TipoProducto> entity)
        {
            // Nombre de la tabla en la base de datos
            entity.ToTable("tipo_producto");

            // Llave primaria
            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");
            // Configuración de columnas de la clase base
            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd();

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

            // Configuración de columnas de TipoProducto
            entity.Property(e => e.Codigo)
                .HasColumnName("codigo")
                .HasColumnType("VARCHAR(50)")
                .IsRequired();

            entity.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasColumnType("VARCHAR(200)")
                .IsRequired();

            // Relación uno a muchos con Producto
            entity.HasMany(e => e.Productos)
                .WithOne(p => p.TipoProducto)
                .HasForeignKey(p => p.IdTipoProducto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("producto_tipoproducto_fk");
            entity.SeedTipoProducto();
        }
    }
}
