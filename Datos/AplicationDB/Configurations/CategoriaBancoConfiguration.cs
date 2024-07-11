using Datos.Models;
using Datos.Seeders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    partial class CategoriaBancoConfiguration : IEntityTypeConfiguration<CategoriaBanco>
    {
        public void Configure(EntityTypeBuilder<CategoriaBanco> builder)
        {
            builder.ToTable("categorias_bancos");

            builder.HasKey(e => e.Id)
                .HasName("PRIMARY");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Codigo)
                .HasColumnName("codigo")
                .HasColumnType("VARCHAR(50)")
                .IsRequired();

            builder.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .IsRequired();

            builder.Property(e => e.Descripcion)
                .HasColumnName("descripcion");
            builder.Property(e => e.Activo)
                .HasColumnName("activo")
                .HasColumnType("bit")
                .IsRequired();

            builder.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime");

            builder.HasQueryFilter(e => e.Activo);

            builder.HasMany(e => e.Bancos)
                .WithOne(e => e.CategoriaBanco)
                .HasForeignKey(e => e.IdCategoriaBanco)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("categoria_banco_bancofk");

            // Llamada al seeder
            builder.SeedCategoriaBancos();
            OnConfigurePartial(builder);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CategoriaBanco> entity);
    }
}