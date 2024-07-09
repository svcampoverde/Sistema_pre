using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.ModelsConfiguration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            // Configuración de la tabla
            builder.ToTable("usuario");

            // Configuración de la clave primaria
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id)
                   .HasColumnName("id")
                   .ValueGeneratedOnAdd()
                   .IsRequired();
            // BaseEntity properties
            builder.Property(u => u.Activo)
                   .HasColumnName("activo")
                   .IsRequired();

            builder.Property(u => u.FechaCreacionUTC)
                   .HasColumnName("fecha_creacion_utc")
                   .IsRequired();

            builder.Property(u => u.FechaModificacionUTC)
                   .HasColumnName("fecha_modificacion_utc")
                   .IsRequired();
            // Configuración de otras propiedades
            builder.Property(u => u.IdPersona)
                   .HasColumnName("id_persona")
                   .IsRequired();

            builder.Property(u => u.NombreUsuario)
                   .HasColumnName("nombre_usuario")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(u => u.ContrasenaHash)
                   .HasColumnName("contrasena_hash")
                   .IsRequired();

            builder.Property(u => u.ContrasenaSalt)
                   .HasColumnName("contrasena_salt")
                   .IsRequired();

            builder.Property(u => u.IdRol)
                   .HasColumnName("id_rol")
                   .IsRequired();

            // Relaciones
            builder.HasOne(u => u.Persona)
                   .WithOne(p => p.UsuarioNavegation)
                   .HasForeignKey<Usuario>(u => u.IdPersona)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.Rol)
                   .WithMany(r => r.Usuarios)
                   .HasForeignKey(u => u.IdRol)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasQueryFilter(e => e.Activo);


        }
    }
}
