using System;
using Sagep.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sagep.Infra.Data.Mappings
{
    public class DetentoMap : IEntityTypeConfiguration<Detento>
    {
        public void Configure(EntityTypeBuilder<Detento> builder)
        {
            builder.ToTable("Detentos");

            builder
                .HasKey(c => c.Id);
        }
    }
}