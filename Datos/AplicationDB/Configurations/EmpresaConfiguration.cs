﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using Datos.AplicationDB;
using Datos.Models;

namespace Datos.AplicationDB.Configurations
{
    public partial class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> entity)
        {
            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.ToTable("empresa");

            entity.HasIndex(e => e.Idtipoempresa).HasName("tipempresa_empfk");

            entity.Property(e => e.Id).HasColumnName("idempresa");

            entity.Property(e => e.Correo)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("correo");

            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("descripcion");

            entity.Property(e => e.Direccion)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("direccion");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(1)
                .HasColumnName("estado")
                .IsFixedLength();

            entity.Property(e => e.Idtipoempresa).HasColumnName("idtipoempresa");

            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdtipoempresaNavigation)
                .WithMany(p => p.Empresas)
                .HasForeignKey(d => d.Idtipoempresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tipempresa_empfk");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Empresa> entity);
    }
}
