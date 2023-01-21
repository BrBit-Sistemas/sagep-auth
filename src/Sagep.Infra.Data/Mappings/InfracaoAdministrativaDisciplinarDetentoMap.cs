using System;
using Sagep.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sagep.Domain.Enums;

namespace Sagep.Infra.Data.Mappings
{
    public class InfracaoAdministrativaDisciplinarDetentoMap : IEntityTypeConfiguration<InfracaoAdministrativaDisciplinarDetento>
    {
        public void Configure(EntityTypeBuilder<InfracaoAdministrativaDisciplinarDetento> builder)
        {
            builder.ToTable("InfracoesAdministrativasDisciplinaresDetentos");

            builder.HasKey(c => new { c.InfracaoAdministrativaDisciplinarId, c.DetentoId });

            // Relationships
            builder
                .HasOne(c => c.InfracaoAdministrativaDisciplinar)
                .WithMany(c => c.Infratores)
                .HasForeignKey(c => c.InfracaoAdministrativaDisciplinarId)
                .OnDelete(DeleteBehavior.NoAction);
            
            builder
                .HasOne(c => c.Detento)
                .WithMany(c => c.Infracoes)
                .HasForeignKey(c => c.DetentoId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}