using System;
using Sagep.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sagep.Domain.Enums;
using Sagep.Domain.Interfaces;

namespace Sagep.Infra.Data.Mappings
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        private ITenantRepository _tenantRepository;

        public AlunoMap(ITenantRepository tenantRepository)
        {
            _tenantRepository = tenantRepository;
        }

        public AlunoMap() {}

        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Escolaridade)
                .HasDefaultValue(EscolaridadeEnum.NAO_INFORMADO);
            
            builder.Property(c => c.AtividadesEducacionais)
                .IsRequired(false);
                            
            builder.Property(c => c.TurmaNumero)
                .HasMaxLength(25)
                .IsRequired(false);
            
            builder.Property(c => c.TurmaSala)
                .HasMaxLength(25)
                .IsRequired(false);
            
            builder.Property(c => c.IsEnturmado)
                .HasDefaultValue(false);

            builder.Property(c => c.CejaId)
                .IsRequired(false);

            builder.Property(c => c.CejaMatricula)
                .IsRequired(false);
            

            //Relacionamentos
            builder
                .HasOne(c => c.Tenant)
                .WithMany(c => c.Alunos)
                .HasForeignKey(c => c.TenantId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(c => c.TenantId)
                .IsRequired();

            builder
                .HasMany(c => c.AlunosEja)
                .WithOne(c => c.Aluno)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(c => c.AlunosEncceja)
                .WithOne(c => c.Aluno)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(c => c.AlunosEnem)
                .WithOne(c => c.Aluno)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasMany(c => c.AlunosLeitores)
                .WithOne(c => c.Aluno)
                .OnDelete(DeleteBehavior.NoAction);
            
            builder
                .HasMany(c => c.AlunosRedacaoDPU)
                .WithOne(c => c.Aluno)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasIndex(c => c.DetentoId)
                .HasFilter("\"IsDeleted\"=" + "\'" + 0 + "\'")
                .IsUnique();
            
            builder.HasQueryFilter(p => !p.IsDeleted);
        }
    }
}