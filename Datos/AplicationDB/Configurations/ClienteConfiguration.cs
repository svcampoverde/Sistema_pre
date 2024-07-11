using Datos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Datos.AplicationDB.Configurations
{
    public partial class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
            entity.ToTable("cliente"); // 

            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.Property(e => e.Id)
                .HasColumnName("id").HasColumnType("int")
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            entity.Property(e => e.IdPersona)
                .HasColumnName("idPersona")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.IdCiudad)
                .HasColumnName("idCiudad")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.LimiteCredito)
                .HasColumnName("limite_credito")
                .HasColumnType("decimal(18, 2)")
                .IsRequired();

            entity.Property(e => e.ContactoCorreo)
                .HasColumnName("contacto_correo")
                .HasColumnType("VARCHAR(200)");

            entity.Property(e => e.ContactoTelefono)
                .HasColumnName("contacto_telefono")
                .HasColumnType("VARCHAR(20)");

            entity.Property(e => e.FechaRegistro)
                .HasColumnName("fecha_registro")
                .HasColumnType("datetime")
                .IsRequired();

            entity.Property(e => e.Activo)
                .HasColumnName("activo")
                .HasColumnType("bit")
                .IsRequired();

            // Relaciones con otras entidades
            entity.HasOne(d => d.Persona)
                .WithMany(e=>e.Clientes)
                .HasForeignKey(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_personafk");

            entity.HasOne(d => d.Ciudad)
                .WithMany(e => e.Clientes)
                .HasForeignKey(d => d.IdCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_ciudadfk");

            entity.HasOne(d => d.Cuenta)
                .WithMany(e => e.Clientes)
                .HasForeignKey(d => d.CuentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_cuentafk");

            entity.HasOne(d => d.Empresa)
                .WithMany(e => e.Clientes)
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_empresafk");

            entity.HasOne(d => d.FormaPago)
                .WithMany(e => e.Clientes)
                .HasForeignKey(d => d.FormaPagoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_formapagofk");

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

        partial void OnConfigurePartial(EntityTypeBuilder<Cliente> entity);
    }
}
