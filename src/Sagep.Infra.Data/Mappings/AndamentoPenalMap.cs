using System.Reflection.Emit;
using System.Collections.Immutable;
using System;
using Sagep.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sagep.Domain.Enums;
using Sagep.Domain.Interfaces;

namespace Sagep.Infra.Data.Mappings
{
    public class AndamentoPenalMap : IEntityTypeConfiguration<AndamentoPenal>
    {
        public void Configure(EntityTypeBuilder<AndamentoPenal> builder)
        {
            builder.ToTable("AndamentoPenal");

            builder
                .HasKey(c => c.Id);
            
            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(c => c.DataEventoPrincipal)
                .IsRequired();

            builder.Property(c => c.Historico)
                .IsRequired(false);

            builder.Property(c => c.Observacao)
                .IsRequired(false);

            builder.Property(c => c.EnderecoCompleto)
                .HasMaxLength(255)
                .IsRequired(false);
            
            builder.Property(c => c.Telefone)
                .HasMaxLength(255)
                .IsRequired(false);
            
            //Relacionamento
            builder
                .HasOne(c => c.Detento)
                .WithOne(c => c.AndamentoPenal)
                .HasForeignKey<AndamentoPenal>(c => c.DetentoId)
                .OnDelete(DeleteBehavior.NoAction);
            
            builder
                .HasOne(c => c.Tenant)
                .WithMany(c => c.AndamentoPenal)
                .HasForeignKey(x => x.TenantId)
                .OnDelete(DeleteBehavior.NoAction);
            
            builder
                .HasIndex(c => c.DetentoId)
                .IsUnique();

            builder.HasQueryFilter(p => !p.IsDeleted);
        }
    }
}