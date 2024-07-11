using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class AtributoConfiguration : IEntityTypeConfiguration<Atributo>
    {
        public void Configure(EntityTypeBuilder<Atributo> entity)
        {
            entity.ToTable("atributos"); // Nombre de la tabla en la base de datos

            entity.HasKey(e => e.Id); // Definición de la clave primaria

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); // Configuración de la columna Id

            entity.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasColumnType("VARCHAR(200)")
                .IsRequired(); // Configuración de la columna Nombre

            entity.Property(e => e.Unidades)
                .HasColumnName("unidades")
                .HasColumnType("VARCHAR(50)"); // Configuración de la columna Unidades

            entity.Property(e => e.IdCategoriaAtributo)
                .HasColumnName("fk_categoria_atributo")
                .HasColumnType("int")
                .IsRequired(); // Configuración de la columna IdCategoriaAtributo
            entity.Property(e => e.Activo)
              .HasColumnName("activo")
              .HasColumnType("bit")
              .IsRequired();
            // Query Filter para propiedades activas
            entity.HasQueryFilter(e => e.Activo);
            entity.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime");

            // Relación muchos a uno con CategoriaAtributo
            entity.HasOne(e => e.CategoriaAtributo)
                .WithMany(c => c.Atributos)
                .HasForeignKey(e => e.IdCategoriaAtributo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("atributo_categoria_atributo_fk"); // Relación con CategoriaAtributo, configuración de la clave externa

            // Llamada a método parcial para configuración adicional
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Atributo> entity);
    }
}
