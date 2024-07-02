using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> entity)
        {
            entity.ToTable("categoria"); // 

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id").HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.Codigo)
                .HasColumnName("codigo")
                .HasColumnType("nvarchar(50)") // Ajusta según la longitud necesaria
                .IsRequired();

            entity.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasColumnType("nvarchar(200)"); // Ajusta según la longitud necesaria

            // Relación uno a muchos con Producto
            entity.HasMany(e => e.Productos)
                .WithOne(e => e.IdCategoriaNavigation)
                .HasForeignKey(e => e.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("categoria_productofk");

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

        partial void OnConfigurePartial(EntityTypeBuilder<Categoria> entity);
    }
}
