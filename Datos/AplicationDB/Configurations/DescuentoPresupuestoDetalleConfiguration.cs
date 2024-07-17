using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public class DescuentoPresupuestoDetalleConfiguration : IEntityTypeConfiguration<DescuentoPresupuestoDetalle>
    {
        public void Configure(EntityTypeBuilder<DescuentoPresupuestoDetalle> entity)
        {
            // Configurar la tabla
            entity.ToTable("descuento_presupuesto_detalle");

            // Configurar la clave primaria
            entity.HasKey(dpd => dpd.Id);

            // Configurar las propiedades
            entity.Property(dpd => dpd.IdPresupuestoDetalle)
                .IsRequired()
                .HasColumnName("idPresupuestoDetalle");

            entity.Property(dpd => dpd.IdDescuento)
                .IsRequired()
                .HasColumnName("idDescuento");
            entity.Property(e => e.Activo)
                  .HasColumnName("activo")
                  .HasColumnType("bit")
                  .IsRequired();
            entity.Property(e => e.FechaCreacionUTC)
                           .HasColumnName("fecha_creacion_utc")
                           .HasColumnType("datetime")
                           .IsRequired();
            entity.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime").IsRequired(false);
            entity.HasQueryFilter(e => e.Activo);
            // Configurar las relaciones
            entity.HasOne(dpd => dpd.PresupuestoDetalle)
                .WithMany(pd => pd.DescuentoPresupuestoDetalle)
                .HasForeignKey(dpd => dpd.IdPresupuestoDetalle)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_descuento_presupuesto_detalle_presupuesto_detalle");

            entity.HasOne(dpd => dpd.Descuento)
                .WithMany(d => d.DescuentoPresupuestoDetalle)
                .HasForeignKey(dpd => dpd.IdDescuento)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_descuento_presupuesto_detalle_descuento");
        }
    }
}