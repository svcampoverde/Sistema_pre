using Datos.Models;
using Datos.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> entity)
        {
            entity.ToTable("ciudad");

            entity.HasKey(e => e.Id)
                .HasName("PK_ciudad");

            entity.Property(e => e.Id)
                .HasColumnName("id")
                .HasColumnType("int");

            entity.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            entity.Property(e => e.IdProvincia)
                .HasColumnName("idProvincia")
                .HasColumnType("int")
                .IsRequired();

 
            // Relación con la tabla Provincia
            entity.HasOne(e => e.ProvinciaNavigation)
                .WithMany(e=>e.Ciudades)
                .HasForeignKey(e => e.IdProvincia)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_ciudad_provincia");

            entity.SeedCiudades();
            OnConfigurePartial(entity);
    


        }
        partial void OnConfigurePartial(EntityTypeBuilder<Ciudad> entity);

    }
}
