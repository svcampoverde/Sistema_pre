using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class ImpuestoProductoCategoriaConfiguration : IEntityTypeConfiguration<ImpuestoProductoCategoria>
    {
        public void Configure(EntityTypeBuilder<ImpuestoProductoCategoria> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.IdProducto);

            builder.Property(e => e.IdCategoriaProducto);

            builder.Property(e => e.IdImpuesto)
                .IsRequired();

            builder.Property(e => e.Activo).HasColumnName("activo").HasColumnType("bit").IsRequired();
            builder.Property(e => e.FechaCreacionUTC)
                           .HasColumnName("fecha_creacion_utc")
                           .HasColumnType("datetime")
                           .IsRequired();
            builder.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime").IsRequired(false);
            builder.HasQueryFilter(e => e.Activo);
            // Relaciones con otras entidades
            builder.HasOne(d => d.Producto)
                .WithMany(p => p.ImpuestosProductoCategoria)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK_ImpuestoProductoCategoria_Producto");

            builder.HasOne(d => d.CategoriaProducto)
                .WithMany(p => p.ImpuestoProductoCategorias)
                .HasForeignKey(d => d.IdCategoriaProducto)
                .HasConstraintName("FK_ImpuestoProductoCategoria_CategoriaProducto");

            builder.HasOne(d => d.Impuesto)
                .WithMany(p => p.ImpuestoProductoCategoria)
                .HasForeignKey(d => d.IdImpuesto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ImpuestoProductoCategoria_Impuesto");

            // Configuración adicional
            builder.ToTable("ImpuestoProductoCategoria");
        }
    }
}