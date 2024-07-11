using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Datos.Seeders;
namespace Datos.AplicationDB.Configurations
{
    public partial class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> entity)
        {
            entity.ToTable("rol"); // 

            entity.HasKey(e => e.Id)
                .HasName("PK_rol"); // 

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasColumnType("VARCHAR(200)")  
                .IsRequired();
            entity.Property(e => e.Codigo)
                  .HasColumnName("codigo")
                  .HasColumnType("VARCHAR(70)") 
                  .IsRequired();

       
            entity.HasMany(e => e.Usuarios)
                .WithOne(u => u.Rol)
                .HasForeignKey(u => u.IdRol)
                .OnDelete(DeleteBehavior.Restrict)  
                .HasConstraintName("FK_usuario_rol");

            entity.Property(e => e.Activo)
                .HasColumnName("activo")
                .HasColumnType("bit")
                .IsRequired();


            // 
            entity.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime");
 
            entity.HasQueryFilter(e => e.Activo);
            entity.SeedRol();
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Rol> entity);
    }
}
