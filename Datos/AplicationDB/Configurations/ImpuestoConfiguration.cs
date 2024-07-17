using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class ImpuestoConfiguration : IEntityTypeConfiguration<Impuesto>
    {
        public void Configure(EntityTypeBuilder<Impuesto> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(100); // Ajusta el tamaño máximo según tus necesidades

            builder.Property(e => e.Tasa)
                .IsRequired()
                .HasColumnType("decimal(18, 2)"); // Define el tipo y precisión de la tasa

            builder.Property(e => e.EsPorcentaje)
                .IsRequired();
            builder.Property(e => e.Activo)
                 .HasColumnName("activo")
                 .HasColumnType("bit")
                 .IsRequired();
            builder.Property(e => e.FechaCreacionUTC)
                           .HasColumnName("fecha_creacion_utc")
                           .HasColumnType("datetime")
                           .IsRequired();
            builder.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime").IsRequired(false);
            builder.HasQueryFilter(e => e.Activo);
            // Relación con ImpuestoProductoCategoria
            builder.HasMany(e => e.ImpuestoProductoCategoria)
                .WithOne(e => e.Impuesto)
                .HasForeignKey(e => e.IdImpuesto)
                .HasConstraintName("FK_Impuesto_ImpuestoProductoCategoria");

            // Configuración adicional
            builder.ToTable("Impuesto");
        }
    }
}