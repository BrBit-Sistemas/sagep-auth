using System;
using Sagep.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sagep.Domain.Enums;

namespace Sagep.Infra.Data.Mappings
{
    public class ServidorEstadoReforcoRegraVagaDiaMap : IEntityTypeConfiguration<ServidorEstadoReforcoRegraVagaDia>
    {
        public void Configure(EntityTypeBuilder<ServidorEstadoReforcoRegraVagaDia> builder)
        {
            builder.ToTable("ServidorEstadoReforcoRegraVagasDia");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            //Relacionamentos
             builder
                .HasIndex(c => c.ServidorEstadoReforcoRegraId)
                .IsUnique(false);

            builder
                .HasOne(c => c.ServidorEstadoReforcoRegra)
                .WithMany(c => c.VagasPorDia)
                .HasForeignKey(c => c.ServidorEstadoReforcoRegraId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
