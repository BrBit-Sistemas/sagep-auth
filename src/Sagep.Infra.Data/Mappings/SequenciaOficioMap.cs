using System.Data;
using System;
using Sagep.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sagep.Domain.Enums;

namespace Sagep.Infra.Data.Mappings
{
    public class SequenciaOficioMap : IEntityTypeConfiguration<SequenciaOficio>
    {
        public void Configure(EntityTypeBuilder<SequenciaOficio> builder)
        {
            builder.ToTable("SequenciasOficios");

            builder
                .HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.HasQueryFilter(p => !p.IsDeleted);
        }
    }
}