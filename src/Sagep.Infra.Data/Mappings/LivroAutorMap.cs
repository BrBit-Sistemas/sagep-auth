using System;
using Sagep.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sagep.Domain.Enums;

namespace Sagep.Infra.Data.Mappings
{
    public class LivroAutorMap : IEntityTypeConfiguration<LivroAutor>
    {
        public void Configure(EntityTypeBuilder<LivroAutor> builder)
        {
            builder.ToTable("LivrosAutores");

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
                .WithOne(c => c.LivroAutor)
                .HasForeignKey(c => c.LivroAutorId);
            
            builder.HasQueryFilter(p => !p.IsDeleted);
        }
    }
}