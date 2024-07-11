using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class ServicioConfiguration : IEntityTypeConfiguration<Servicio>
    {
        public void Configure(EntityTypeBuilder<Servicio> entity)
        {
            entity.ToTable("servicio"); // 

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id") // Nombre de la columna en minúsculas y específico para Servicio
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasColumnType("VARCHAR(200)") 
                .IsRequired();

            entity.Property(e => e.Activo)
                .HasColumnName("activo")
                .HasColumnType("bit")
                .IsRequired();

            // Relación con PresupuestoDetalle (uno a muchos)
            entity.HasMany(e => e.PresupuestoDetalles)
                .WithOne(p => p.ServicionNavegation)
                .HasForeignKey(e => e.IdServicio)
                .OnDelete(DeleteBehavior.Restrict) // 
                .HasConstraintName("servicio_presupuestodetallefk");

            // Relación con Proveedor (muchos a muchos o uno a muchos según tu diseño)
            entity.HasMany(e => e.Proveedores)
                .WithOne(p => p.ServicionNavegation)
                .HasForeignKey(e => e.ServicioId)
                .OnDelete(DeleteBehavior.Restrict) // 
                .HasConstraintName("servicio_proveedorfk");

            // 
            entity.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime");

            entity.HasQueryFilter(e => e.Activo);
            // 
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Servicio> entity);
    }
}
