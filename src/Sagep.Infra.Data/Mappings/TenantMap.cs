using System;
using Sagep.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sagep.Infra.Data.Mappings
{
    public class TenantMap : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {
            builder.ToTable("Tenants");

            builder
                .HasKey(c => c.Id);

            builder.Property(c => c.ApiKey)
                .IsRequired();

            builder
                .HasIndex(c => c.ApiKey)
                .IsUnique();
            
            builder.Property(c => c.Nome)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(c => c.OficioLeituraAssinaturaNome)
                .HasMaxLength(500)
                .IsRequired(false);
            
            builder.Property(c => c.OficioLeituraAssinaturaCargo)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(c => c.OficioLeituraAssinaturaMatricula)
                .HasMaxLength(500)
                .IsRequired(false);
            
            builder.Property(c => c.EnderecoLogradouro)
                .HasMaxLength(500)
                .IsRequired(false);
            
            builder.Property(c => c.EnderecoLogradouro)
                .IsRequired(false);
            
            builder.Property(c => c.EnderecoLogradouroNumero)
                .HasMaxLength(10)
                .IsRequired(false);
            
            builder.Property(c => c.EnderecoCidade)
                .HasMaxLength(50)
                .IsRequired(false);
            
            builder.Property(c => c.EnderecoEstado)
                .HasMaxLength(25)
                .IsRequired(false);
            
            builder.Property(c => c.EnderecoCEP)
                .HasMaxLength(10)
                .IsRequired(false);
            
            builder.Property(c => c.OficioLeituraVocativo1)
                .HasMaxLength(50)
                .IsRequired(false);
            
            builder.Property(c => c.OficioLeituraVocativo2)
                .HasMaxLength(500)
                .IsRequired(false);
            
            builder.Property(c => c.OficioLeituraVocativo3)
                .HasMaxLength(500)
                .IsRequired(false);
            
            builder.Property(c => c.TelefoneDDD)
                .HasMaxLength(2)
                .IsRequired(false);
            
            builder.Property(c => c.TelefoneNumero)
                .HasMaxLength(12)
                .IsRequired(false);

            builder.Property(c => c.EmailPrincipal)
                .IsRequired(false);

            builder.HasQueryFilter(p => !p.IsDeleted);

            //Seed for dev
            builder.HasData(
                new Tenant
                {
                    Id = Guid.Parse("206c645a-2966-4ad9-19a3-dced7c201bc4"),
                    IsDeleted = false,
                    CreatedAt = DateTimeOffset.UtcNow,
                    CreatedBy = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb9"),
                    UpdatedAt = DateTimeOffset.UtcNow,
                    UpdatedBy = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb9"),
                    ApiKey = Guid.Parse("06b5fb02-57cb-126b-3ab2-a05f805f1e97"),
                    Nome = "Tenância Presídio Regional de Criciúma",
                    NomeExibicao = "PRESÍDIO REGIONAL CRICIÚMA"         
                }
            );
        }
    }
}