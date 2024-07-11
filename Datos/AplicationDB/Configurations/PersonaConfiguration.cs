using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> entity)
        {
            entity.ToTable("persona"); // 

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id").HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.Cedula)
                .HasColumnName("cedula")
                .HasColumnType("VARCHAR(20)")
                .IsRequired();

            entity.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            entity.Property(e => e.Apellido)
                .HasColumnName("apellido")
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            entity.Property(e => e.Genero)
                .HasColumnName("genero")
                .HasColumnType("VARCHAR(20)");

            entity.Property(e => e.Telefono)
                .HasColumnName("telefono")
                .HasColumnType("VARCHAR(20)");

            entity.Property(e => e.Celular)
                .HasColumnName("celular")
                .HasColumnType("VARCHAR(20)");

            entity.Property(e => e.Correo)
                .HasColumnName("correo")
                .HasColumnType("VARCHAR(100)");

            entity.Property(e => e.Direccion)
                .HasColumnName("direccion")
                .HasColumnType("VARCHAR(200)");

            entity.Property(e => e.IdCiudad)
                .HasColumnName("idCiudad")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.Activo)
                .HasColumnName("activo")
                .HasColumnType("bit")
                .IsRequired();
            entity.HasQueryFilter(e => e.Activo);
            entity.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime");
            // Relaciones con otras entidades
            entity.HasOne(d => d.CiudadNavegation)
                .WithMany()
                .HasForeignKey(d => d.IdCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("persona_ciudadfk");
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Persona> entity);
    }
}
