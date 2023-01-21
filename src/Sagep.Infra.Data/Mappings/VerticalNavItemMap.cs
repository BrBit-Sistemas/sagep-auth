using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sagep.Domain.Models;

namespace Sagep.Infra.Data.Mappings
{
    public class VerticalNavItemMap : IEntityTypeConfiguration<VerticalNavItem>
    {
        public void Configure(EntityTypeBuilder<VerticalNavItem> builder)
        {
            builder.ToTable("VerticalNavItems");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();
        }
    }
}