using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> entity)
        {
            entity.ToTable("usuario"); // Nombre de la tabla en la base de datos

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id") // Nombre de la columna en la base de datos
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.NombreUsuario)
                .HasColumnName("nombre_usuario") // Nombre de la columna en la base de datos
                .HasColumnType("varchar(100)") // Tipo y tamaño de datos según tus requisitos
                .IsRequired();

            entity.Property(e => e.Contrasena)
                .HasColumnName("contrasena") // Nombre de la columna en la base de datos

                .IsRequired();

            entity.Property(e => e.ContrasenaHash)
                .HasColumnName("contrasena_hash"); // Ajusta según el tamaño necesario para el hash

            entity.Property(e => e.RolId)
                .HasColumnName("rol_id") // Nombre de la columna en la base de datos
                .HasColumnType("int")
                .IsRequired();

            // Relación con Persona (uno a uno)
            entity.HasOne(d => d.Persona)
                .WithOne(p => p.UsuarioNavegation)
                .HasForeignKey<Usuario>(d => d.IdPersona)
                .OnDelete(DeleteBehavior.Restrict) // 
                .HasConstraintName("usuario_persona_fk");

            // Relación con Rol
            entity.HasOne(d => d.Rol)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.Restrict) // 
                .HasConstraintName("usuario_rol_fk");

            // 
            entity.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime");

            entity.Property(e => e.Activo)
                .HasColumnName("activo")
                .HasColumnType("bit")
                .IsRequired();

            entity.HasQueryFilter(e => e.Activo);
            // 
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Usuario> entity);
    }
}
