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

            entity.Property(e => e.PersonaId)
                .HasColumnName("idPersona")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.CiudadId)
                .HasColumnName("idCiudad")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.CuentaId)
                .HasColumnName("idCuenta")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.EmpresaId)
                .HasColumnName("idEmpresa")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.FormaPagoId)
                .HasColumnName("idFormapago")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(e => e.LimiteCredito)
                .HasColumnName("limite_credito")
                .HasColumnType("decimal(18, 2)")
                .IsRequired();

            entity.Property(e => e.ContactoCorreo)
                .HasColumnName("contacto_correo")
                .HasColumnType("nvarchar(200)");

            entity.Property(e => e.ContactoTelefono)
                .HasColumnName("contacto_telefono")
                .HasColumnType("nvarchar(20)");

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
                .WithMany()
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_personafk");

            entity.HasOne(d => d.Ciudad)
                .WithMany()
                .HasForeignKey(d => d.CiudadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_ciudadfk");

            entity.HasOne(d => d.Cuenta)
                .WithMany()
                .HasForeignKey(d => d.CuentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_cuentafk");

            entity.HasOne(d => d.Empresa)
                .WithMany()
                .HasForeignKey(d => d.EmpresaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_empresafk");

            entity.HasOne(d => d.FormaPago)
                .WithMany()
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
