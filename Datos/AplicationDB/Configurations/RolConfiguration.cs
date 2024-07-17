using Datos.Models;
using Datos.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> entity)
        {
            entity.ToTable("rol");

            entity.HasKey(e => e.Id).HasName("PK_rol");

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Nombre)
                .HasColumnName("nombre") // Cambiado a "nombre"
                .HasColumnType("varchar(255)")
                .IsRequired();

            entity.Property(e => e.Descripcion)
                .HasColumnName("descripcion") 
                
                .IsRequired(false);

            entity.Property(e => e.Codigo)
                .HasColumnName("codigo")
                .HasColumnType("VARCHAR(70)")
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
                .HasColumnType("datetime")
                .IsRequired(false);

            entity.HasMany(e => e.Usuarios)
                .WithOne(u => u.Rol)
                .HasForeignKey(u => u.IdRol)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_usuario_rol");

            entity.HasQueryFilter(e => e.Activo);

            // Llama al seeder si es necesario
            entity.SeedRol();

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Rol> entity);
    }
}
