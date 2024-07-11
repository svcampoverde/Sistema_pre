using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class CuentaConfiguration : IEntityTypeConfiguration<Cuenta>
    {
        public void Configure(EntityTypeBuilder<Cuenta> entity)
        {
            entity.ToTable("cuenta"); // 

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.NumCuenta)
                .HasColumnName("numcuenta")
                .HasColumnType("VARCHAR(80)") // Ajusta según la longitud necesaria
                .IsRequired();

            entity.Property(e => e.IdBanco)
                .HasColumnName("idBanco")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.IdTipoCuenta)
                .HasColumnName("idTipocuenta")
                .HasColumnType("int")
                .IsRequired();

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

            // Relaciones
            entity.HasOne(e => e.IdBancoNavigation)
                .WithMany(p => p.Cuenta)
                .HasForeignKey(e => e.IdBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("banco_cuentafk");

            entity.HasOne(e => e.IdTipoCuentaNavigation)
                .WithMany(p => p.Cuenta)
                .HasForeignKey(e => e.IdTipoCuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tipocuenta_cuentafk");

            entity.HasQueryFilter(e => e.Activo);
            // 
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Cuenta> entity);
    }
}
