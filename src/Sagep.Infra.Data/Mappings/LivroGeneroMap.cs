using System;
using Sagep.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sagep.Domain.Enums;

namespace Sagep.Infra.Data.Mappings
{
    public class LivroGeneroMap : IEntityTypeConfiguration<LivroGenero>
    {
        public void Configure(EntityTypeBuilder<LivroGenero> builder)
        {
            builder.ToTable("LivrosGeneros");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(c => c.Nome)
                .HasMaxLength(255)
                .IsRequired();

            //Relacionamentos
            builder
                .HasMany(c => c.Livros)
                .WithOne(c => c.LivroGenero)
                .HasForeignKey(c => c.LivroGeneroId);
            
            builder.HasQueryFilter(p => !p.IsDeleted);
        }
    }
}