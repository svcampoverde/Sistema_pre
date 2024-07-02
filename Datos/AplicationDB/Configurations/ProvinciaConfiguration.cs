using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class ProvinciaConfiguration : IEntityTypeConfiguration<Provincia>
    {
        public void Configure(EntityTypeBuilder<Provincia> entity)
        {
            entity.ToTable("provincias"); 

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                    .HasColumnName("id") // Nombre de la columna en minúsculas
                    .HasColumnType("int")
                    .IsRequired()
                    .ValueGeneratedOnAdd(); 


            entity.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasColumnType("nvarchar(200)") 
                .IsRequired();
            entity.HasMany(e => e.Ciudades)
                .WithOne(e => e.ProvinciaNavigation)
                .HasForeignKey(e=>e.IdProvincia)
                ;
             
            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Provincia> entity);
    }
}
