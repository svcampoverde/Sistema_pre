using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> entity)
        {
            entity.ToTable("producto"); // 

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id") // Nombre de la columna en minúsculas y específico para Producto
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasColumnType("nvarchar(200)")
                .IsRequired();

            entity.Property(e => e.Precio)
                .HasColumnName("precio")
                .HasColumnType("float")
                .IsRequired();

            entity.Property(e => e.IdCategoria)
                .HasColumnName("idCategoria")
                .HasColumnType("int")
                .IsRequired();

            // Relación con Categoria
            entity.HasOne(d => d.IdCategoriaNavigation)
                .WithMany()
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("producto_categoriafk");

            // 
            entity.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime");

            entity.Property(e => e.Activo)
                .HasColumnName("activo")
                .HasColumnType("bit")
                .IsRequired();

            entity.HasQueryFilter(e => e.Activo);
            // 
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Producto> entity);
    }
}
