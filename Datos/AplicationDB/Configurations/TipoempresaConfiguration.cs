using Datos.Models;
using Datos.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class TipoEmpresaConfiguration : IEntityTypeConfiguration<TipoEmpresa>
    {
        public void Configure(EntityTypeBuilder<TipoEmpresa> entity)
        {
            entity.ToTable("tipoempresa"); // Nombre de la tabla en la base de datos

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id").HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.Codigo)
                .HasColumnName("codigo") // Nombre de la columna en la base de datos
                .HasColumnType("varchar(20)") // Tipo y tamaño de datos según tus requisitos
                .IsRequired();

            entity.Property(e => e.Descripcion)
                .HasColumnName("descripcion") // Nombre de la columna en la base de datos
                .HasColumnType("varchar(200)") // Tipo y tamaño de datos según tus requisitos
                .IsRequired();

            entity.Property(e => e.Activo)
                .HasColumnName("activo")
                .HasColumnType("bit")
                .IsRequired();

            // Relación con Empresa (uno a muchos)
            entity.HasMany(e => e.Empresas)
                .WithOne(p => p.IdTipoEmpresaNavigation)
                .HasForeignKey(e => e.IdTipoEmpresa)
                .OnDelete(DeleteBehavior.Restrict) // 
                .HasConstraintName("tipoempresa_empresafk");

            // 
            entity.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime");
 
            entity.HasQueryFilter(e => e.Activo);
            entity.SeedTipoEmpresa();
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<TipoEmpresa> entity);
    }
}
