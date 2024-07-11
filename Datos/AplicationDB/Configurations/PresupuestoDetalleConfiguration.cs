using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class PresupuestoDetalleConfiguration : IEntityTypeConfiguration<PresupuestoDetalle>
    {
        public void Configure(EntityTypeBuilder<PresupuestoDetalle> entity)
        {
            entity.ToTable("presupuesto_detalle"); // 

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id") // Nombre de la columna en minúsculas y específico para PresupuestoDetalle
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.Servicio)
                .HasColumnName("servicio")
                .HasColumnType("VARCHAR(200)"); // Ajusta según la longitud necesaria

            entity.Property(e => e.IdServicio)
                .HasColumnName("idServicio")
                .HasColumnType("int");

            entity.Property(e => e.IdProducto)
                .HasColumnName("idProducto")
                .HasColumnType("int");

            entity.Property(e => e.IdPresupuesto)
                .HasColumnName("idPresupuesto")
                .HasColumnType("int")
                .IsRequired();
           entity.Property(e => e.Activo)
                .HasColumnName("activo")
                .HasColumnType("bit")
                .IsRequired();

            // Relaciones con otras entidades
            entity.HasOne(e => e.IdPresupuestoNavigation)
                .WithMany(e=>e.PresupuestoDetalles)
                .HasForeignKey(e => e.IdPresupuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("presupuesto_detalle_presupuestofk");

            entity.HasOne(e => e.IdproductoNavigation)
                .WithMany(e => e.PresupuestoDetalles)
                .HasForeignKey(e => e.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("presupuesto_detalle_productofk");

            entity.HasOne(e => e.ServicionNavegation)
                .WithMany(e=>e.PresupuestoDetalles)
                .HasForeignKey(e => e.IdServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("presupuesto_detalle_serviciofk");

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

        partial void OnConfigurePartial(EntityTypeBuilder<PresupuestoDetalle> entity);
    }
}
