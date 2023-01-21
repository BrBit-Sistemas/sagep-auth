using System.Reflection.Emit;
using System.Collections.Immutable;
using System;
using Sagep.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sagep.Domain.Enums;

namespace Sagep.Infra.Data.Mappings
{
    public class DetentoSaidaTemporariaMap : IEntityTypeConfiguration<DetentoSaidaTemporaria>
    {
        public void Configure(EntityTypeBuilder<DetentoSaidaTemporaria> builder)
        {
            builder.ToTable("DetentoSaidasTemporaria");

            builder
                .HasKey(c => c.Id);

            //Relacionamentos
            builder
                .HasIndex(c => c.DetentoId)
                .IsUnique(false);
                
            builder.HasQueryFilter(p => !p.IsDeleted);
        }
    }
}