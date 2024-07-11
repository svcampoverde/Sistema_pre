using Datos.Models;
using Datos.Seeders;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public class CategoriaBancoConfiguration : IEntityTypeConfiguration<CategoriaBanco>
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
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            builder.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasColumnType("nvarchar(200)");

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

            // Relación uno a muchos con Banco
            builder.HasMany(e => e.Bancos)
                .WithOne(e => e.CategoriaBanco)
                .HasForeignKey(e => e.IdCategoriaBanco)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("categoria_banco_bancofk");

            // Llamada al seeder
            builder.SeedCategoriaBancos();
        }
    }
}
