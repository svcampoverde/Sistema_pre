using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> entity)
        {
            entity.ToTable("proveedor"); // 

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id") // Nombre de la columna en minúsculas y específico para Proveedor
                .HasColumnType("int")
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

            entity.Property(e => e.TipoServicio)
                .HasColumnName("tiposervicio")
                .HasColumnType("VARCHAR(50)");

            entity.Property(e => e.IdCiudad)
                .HasColumnName("idCiudad")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.ServicioId)
                .HasColumnName("idervicio")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.IdCuenta)
                .HasColumnName("idCuenta")
                .HasColumnType("int")
                .IsRequired();

  
            entity.Property(e => e.IdEmpresa)
                .HasColumnName("idempresa")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.Activo)
                .HasColumnName("activo")
                .HasColumnType("bit")
                .IsRequired();

            // Relaciones con otras entidades
            entity.HasOne(d => d.IdCiudadNavigation)
                .WithMany(e=>e.Proveedors)
                .HasForeignKey(d => d.IdCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("proveedor_ciudadfk");
            entity.HasOne(d => d.FormaPago)
                .WithMany(e=>e.Proveedores)
                .HasForeignKey(d => d.IdFormaPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("proveedor_IdFormaPagofk");

            entity.HasOne(d => d.IdCuentaNavigation)
                .WithMany(e => e.Proveedores)
                .HasForeignKey(d => d.IdCuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("proveedor_cuentafk");

            entity.HasOne(d => d.IdEmpresaNavigation)
                .WithMany(e=>e.Proveedores)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("proveedor_empresafk");

            entity.HasOne(d => d.IdPersonaNavigation)
                .WithMany(e=>e.Proveedores)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("proveedor_personafk");

            entity.HasOne(d => d.ServicionNavegation)
                .WithMany(e => e.Proveedores)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("proveedor_serviciofk");

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

        partial void OnConfigurePartial(EntityTypeBuilder<Proveedor> entity);
    }
}
