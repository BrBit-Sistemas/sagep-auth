using System;
using Sagep.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sagep.Domain.Enums;

namespace Sagep.Infra.Data.Mappings
{
    public class InfracaoAdministrativaDisciplinarMap : IEntityTypeConfiguration<InfracaoAdministrativaDisciplinar>
    {
        public void Configure(EntityTypeBuilder<InfracaoAdministrativaDisciplinar> builder)
        {
            builder.ToTable("InfracoesAdministrativasDisciplinares");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            // Relationships
            builder
                .HasOne(c => c.Tenant)
                .WithMany(c => c.InfracoesAdministrativasDisciplinares)
                .HasForeignKey(c => c.TenantId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasQueryFilter(p => !p.IsDeleted);
        }
    }
}