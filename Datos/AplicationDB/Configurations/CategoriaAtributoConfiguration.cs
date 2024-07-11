using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class CategoriaAtributoConfiguration : IEntityTypeConfiguration<CategoriaAtributo>
    {
        public void Configure(EntityTypeBuilder<CategoriaAtributo> entity)
        {
            entity.ToTable("categorias_atributo"); // Nombre de la tabla en la base de datos

            entity.HasKey(e => e.Id); // Definición de la clave primaria

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); // Configuración de la columna Id

            entity.Property(e => e.Codigo)
                .HasColumnName("codigo")
                .HasColumnType("varchar(50)")
                .IsRequired(); // Configuración de la columna Codigo

            entity.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .HasColumnType("VARCHAR(200)")
                .IsRequired(); // Configuración de la columna Descripcion

            entity.HasQueryFilter(e => e.Activo); // Filtro global para entidades activas

            entity.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired(); // Configuración de la columna FechaCreacionUTC

            entity.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime"); // Configuración de la columna FechaModificacionUTC

            // Relación uno a muchos con Atributo
            entity.HasMany(e => e.Atributos)
                .WithOne(a => a.CategoriaAtributo)
                .HasForeignKey(a => a.IdCategoriaAtributo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("categoria_atributo_fk"); // Relación con Atributo, configuración de la clave externa

            // Llamada a método parcial para configuración adicional
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<CategoriaAtributo> entity);
    }
}
