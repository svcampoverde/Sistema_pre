using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public class EventoConfiguration : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> entity)
        {
            entity.ToTable("evento"); 

            entity.HasKey(e => e.Id)
                .HasName("PK_evento");

            entity.Property(e => e.Id)
                .HasColumnName("id").HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasColumnType("VARCHAR(200)") 
                .IsRequired();
            
            entity.Property(e => e.Descripcion)
                .HasColumnName("descripcion")
                .IsRequired(false);

            entity.Property(e => e.FechaEvento)
                .HasColumnName("fecha_evento")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.Promotor)
                .HasColumnName("promotor")
                .HasColumnType("VARCHAR(100)");

            entity.Property(e => e.Artista)
                .HasColumnName("artista")
                .HasColumnType("VARCHAR(100)");

            entity.Property(e => e.Direccion)
                .HasColumnName("direccion")
                .HasColumnType("VARCHAR(200)");

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

            entity.HasOne(e => e.CiudadNavegation)
                .WithMany(e=>e.Eventos)
                .HasForeignKey(e => e.IdCiudad)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_evento_ciudad");
            entity.Property(e => e.FechaCreacionUTC)
                .HasColumnName("fecha_creacion_utc")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.FechaModificacionUTC)
                .HasColumnName("fecha_modificacion_utc")
                .HasColumnType("datetime");


            entity.HasQueryFilter(e => e.Activo);
        }
    }
}
