using Datos.Models;
using Datos.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class TipoServicioConfiguration : IEntityTypeConfiguration<TipoServicio>
    {
        public void Configure(EntityTypeBuilder<TipoServicio> entity)
        {
            entity.ToTable("tipo_servicio"); // Nombre de la tabla en la base de datos

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Codigo)
                .HasColumnName("codigo")
                .HasColumnType("varchar(50)") 
                .IsRequired();

            entity.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasColumnType("varchar(255)")
                        .IsRequired();
            
           entity.Property(e => e.Descripcion)  .IsRequired(false)
                .HasColumnName("descripcion");

            entity.Property(e => e.Activo)
                .HasColumnName("activo")
                .HasColumnType("bit")
                .IsRequired();

            // Relación con Servicio (uno a muchos)
            entity.HasMany(ts => ts.Servicios)
                .WithOne(s => s.TipoServicio)
                .HasForeignKey(s => s.IdTipoServicio)
                .OnDelete(DeleteBehavior.Restrict) 
                .HasConstraintName("servicio_tipo_servicio_fk");
            entity.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();
            entity.Property(e => e.FechaModificacionUTC)
    .HasColumnName("fecha_modificacion_utc")
    .HasColumnType("datetime").IsRequired(false);
            entity.HasQueryFilter(e => e.Activo);
            entity.SeedTipoServicio();
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TipoServicio> entity);
    }
}