using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class PresupuestoDetalleConfiguration : IEntityTypeConfiguration<PresupuestoDetalle>
    {
        public void Configure(EntityTypeBuilder<PresupuestoDetalle> builder)
        {
            builder.ToTable("presupuesto_detalle"); //

            builder.HasKey(e => e.Id)
                .HasName("PRIMARY");

            builder.Property(e => e.Id)
                .HasColumnName("id") // Nombre de la columna en minúsculas y específico para PresupuestoDetalle
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(e => e.ValorBase)
                 .HasColumnType("decimal(18, 2)");

            builder.Property(e => e.TotalDescuentos)
                .HasColumnType("decimal(18, 2)");

            builder.Property(e => e.TotalImpuestos)
                .HasColumnType("decimal(18, 2)");

            builder.Property(e => e.Cantidad)
                .IsRequired();
            builder.Property(e => e.IdServicio)
                .HasColumnName("idServicio")
                .HasColumnType("int");

            builder.Property(e => e.IdProducto)
                .HasColumnName("idProducto")
                .HasColumnType("int");

            builder.Property(e => e.IdPresupuesto)
                .HasColumnName("idPresupuesto")
                .HasColumnType("int")
                .IsRequired();
            builder.Property(e => e.Activo)
                 .HasColumnName("activo")
                 .HasColumnType("bit")
                 .IsRequired();
            //
            builder.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(e => e.FechaModificacionUTC)
                     .HasColumnName("fecha_modificacion_utc")
                     .HasColumnType("datetime").IsRequired(false);

            builder.HasQueryFilter(e => e.Activo);

            // Relaciones con otras entidades
            builder.HasOne(d => d.IdPresupuestoNavigation)
                .WithMany(p => p.PresupuestoDetalles)
                .HasForeignKey(d => d.IdPresupuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoDetalle_Presupuesto");

            builder.HasOne(d => d.IdproductoNavigation)
                .WithMany(p => p.PresupuestoDetalles)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoDetalle_Producto");

            builder.HasOne(d => d.ServicionNavegation)
                .WithMany(p => p.PresupuestoDetalles)
                .HasForeignKey(d => d.IdServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PresupuestoDetalle_Servicio");

            // Colección de descuentos aplicados al detalle
            builder.HasMany(d => d.DescuentoPresupuestoDetalle)
                .WithOne(p => p.PresupuestoDetalle)
                .HasForeignKey(d => d.IdPresupuestoDetalle)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DescuentoPresupuestoDetalle_PresupuestoDetalle");

            OnConfigurePartial(builder);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PresupuestoDetalle> entity);
    }
}