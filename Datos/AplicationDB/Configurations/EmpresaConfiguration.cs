using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> entity)
        {
            entity.ToTable("empresa"); // 

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id").HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasColumnType("VARCHAR(200)")
                .IsRequired();

            entity.Property(e => e.Telefono)
                .HasColumnName("telefono")
                .HasColumnType("VARCHAR(20)");

            entity.Property(e => e.Correo)
                .HasColumnName("correo")
                .HasColumnType("VARCHAR(100)");

            entity.Property(e => e.Direccion)
                .HasColumnName("direccion")
                .HasColumnType("VARCHAR(200)");

            entity.Property(e => e.IdTipoEmpresa)
                .HasColumnName("idTipoEmpresa")
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

            // Relación con TipoEmpresa
            entity.HasOne(d => d.IdTipoEmpresaNavigation)
                .WithMany(e=>e.Empresas)
                .HasForeignKey(d => d.IdTipoEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empresa_tipoempresafk");

            // 
            entity.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime");

            entity.HasQueryFilter(e => e.Activo);
            // 
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Empresa> entity);
    }
}
