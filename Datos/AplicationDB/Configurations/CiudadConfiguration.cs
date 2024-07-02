using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> entity)
        {
            entity.ToTable("ciudad"); // 

            entity.HasKey(e => e.Id)
                .HasName("PK_ciudad"); // 

            entity.Property(e => e.Id)
                .HasColumnName("id") // Nombre de la columna en minúsculas y específico para Ciudad
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasColumnType("nvarchar(100)") 
                .IsRequired();

            entity.Property(e => e.IdProvincia)
                .HasColumnName("id_provincia")
                .HasColumnType("int")
                .IsRequired();

            // Relación con la tabla Provincia
            entity.HasOne(e => e.ProvinciaNavigation)
                .WithMany()
                .HasForeignKey(e => e.IdProvincia)
                .OnDelete(DeleteBehavior.Restrict) // 
                .HasConstraintName("FK_ciudad_provincia");

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
        }
    }
}
