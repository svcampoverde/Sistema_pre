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
    public partial class EventoConfiguration : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> entity)
        {
            entity.HasKey(e => e.Id)
                .HasName("PRIMARY");

            entity.ToTable("evento");

            entity.Property(e => e.Id).HasColumnName("idevento");

            entity.Property(e => e.Artista)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnName("artista");

            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("descripcion");

            entity.Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(1)
                .HasColumnName("estado")
                .IsFixedLength();

            entity.Property(e => e.Fechaevento).HasColumnName("fechaevento");

            entity.Property(e => e.Localidad)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("localidad");

            entity.Property(e => e.Promotor)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnName("promotor");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Evento> entity);
    }
}
