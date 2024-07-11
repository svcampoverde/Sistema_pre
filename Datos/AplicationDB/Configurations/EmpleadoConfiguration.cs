using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> entity)
        {
            entity.ToTable("empleado"); // 

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id").HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.IdPersona)
                .HasColumnName("idPersona")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.Empresa)
                .HasColumnName("empresa")
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            entity.Property(e => e.Sueldo)
                .HasColumnName("sueldo")
                .HasColumnType("float")
                .IsRequired();

            entity.Property(e => e.FechaContrato)
                .HasColumnName("fecha_contrato")
                .HasColumnType("datetime");

            entity.Property(e => e.IdCiudad)
                .HasColumnName("idCiudad")
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

            // Relaciones con otras entidades
            entity.HasOne(d => d.IdPersonaNavigation)
                .WithMany(e=>e.Empleados)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empleado_personafk");

            entity.HasOne(d => d.IdCiudadNavigation)
                .WithMany(e => e.Empleados)
                .HasForeignKey(d => d.IdCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empleado_ciudadfk");
 
            entity.HasQueryFilter(e => e.Activo);
            // 
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Empleado> entity);
    }
}
