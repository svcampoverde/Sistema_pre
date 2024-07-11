using Datos.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class BancoConfiguration : IEntityTypeConfiguration<Banco>
    {
        public void Configure(EntityTypeBuilder<Banco> entity)
        {
            entity.ToTable("bancos");

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            entity.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasColumnType("nvarchar(200)")
                .IsRequired();

            entity.Property(e => e.Direccion)
                .HasColumnName("direccion")
                .HasColumnType("nvarchar(500)");

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

            entity.Property(e => e.IdCategoriaBanco)
                .HasColumnName("idCategoriaBanco")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.Telefono)
                .HasColumnName("telefono")
                .HasColumnType("nvarchar(20)");

            // Relación uno a muchos con Cuentas
            entity.HasMany(e => e.Cuenta)
                .WithOne(e => e.IdBancoNavigation)
                .HasForeignKey(e => e.IdBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("banco_cuentafk");

            // Relación uno a muchos con CategoriaBanco
            entity.HasOne(e => e.CategoriaBanco)
                .WithMany(e => e.Bancos)
                .HasForeignKey(e => e.IdCategoriaBanco)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("banco_categoriabancofk");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Banco> entity);
    }
}
