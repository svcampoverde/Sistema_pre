using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Datos.Models;

namespace Datos.ModelsConfiguration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            // Nombre de la tabla en MySQL
            builder.ToTable("usuario");

            // Definición de la clave primaria
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id)
                   .HasColumnName("id")
                   .ValueGeneratedOnAdd()
                   .IsRequired();

            // Propiedad BaseEntity
            builder.Property(u => u.Activo)
                   .HasColumnName("activo")
                   .IsRequired();

            builder.Property(u => u.FechaCreacionUTC)
                   .HasColumnName("fecha_creacion_utc")
                   .IsRequired();

            // Configuración de FechaModificacionUTC como nullable en MySQL
            builder.Property(u => u.FechaModificacionUTC)
                   .HasColumnName("fecha_modificacion_utc")
                   .HasColumnType("datetime")
                   .IsRequired(false); // Permitir valores nulos en MySQL

            // Otras propiedades
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

            // Relaciones con otras entidades
            builder.HasOne(u => u.PersonaNavegation)
                   .WithOne(p => p.UsuarioNavegation)
                   .HasForeignKey<Usuario>(u => u.IdPersona)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.Rol)
                   .WithMany(r => r.Usuarios)
                   .HasForeignKey(u => u.IdRol)
                   .OnDelete(DeleteBehavior.Restrict);

            // Aplicar filtro global de activo
            builder.HasQueryFilter(e => e.Activo);
        }
    }
}
