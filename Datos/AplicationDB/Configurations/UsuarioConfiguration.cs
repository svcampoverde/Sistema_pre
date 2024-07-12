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
                   .HasColumnName("idPersona")
                   .IsRequired();

            builder.Property(u => u.NombreUsuario)
                   .HasColumnName("nombreUsuario")
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(u => u.ContrasenaHash)
                   .HasColumnName("contrasenaHash")
                   .IsRequired();

            builder.Property(u => u.ContrasenaSalt)
                   .HasColumnName("contrasenaSalt")
                   .IsRequired();

            builder.Property(u => u.IdRol)
                   .HasColumnName("idRol")
                   .IsRequired();

            // Relaciones
            builder.HasOne(u => u.PersonaNavegation)
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
