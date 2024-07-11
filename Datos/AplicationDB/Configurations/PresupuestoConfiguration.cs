using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class PresupuestoConfiguration : IEntityTypeConfiguration<Presupuesto>
    {
        public void Configure(EntityTypeBuilder<Presupuesto> entity)
        {
            entity.ToTable("presupuesto"); // 

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id") // Nombre de la columna en minúsculas y específico para Presupuesto
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Codigo)
                .HasColumnName("codigo")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.Version)
                .HasColumnName("version")
                .HasColumnType("float")
                .IsRequired();

            entity.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasColumnType("VARCHAR(200)")
                .IsRequired();

            entity.Property(e => e.FechaEvento)
                .HasColumnName("fecha_evento")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.FechaCotizacion)
                .HasColumnName("fecha_cotizacion")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.Descuento)
                .HasColumnName("descuento")
                .HasColumnType("float")
                .IsRequired();

            entity.Property(e => e.Iva)
                .HasColumnName("iva")
                .HasColumnType("float")
                .IsRequired();

            entity.Property(e => e.Total)
                .HasColumnName("total")
                .HasColumnType("float")
                .IsRequired();

            entity.Property(e => e.IdEvento)
                .HasColumnName("idevento")
                .HasColumnType("int")
                .IsRequired();
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
                .HasColumnType("datetime");


            // Relación con Evento
            entity.HasOne(d => d.IdeventoNavigation)
                .WithMany()
                .HasForeignKey(d => d.IdEvento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("presupuesto_eventofk");

            // 


            entity.HasQueryFilter(e => e.Activo);
            // 
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Presupuesto> entity);
    }
}
