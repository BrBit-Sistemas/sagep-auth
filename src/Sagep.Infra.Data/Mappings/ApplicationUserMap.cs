using System;
using Sagep.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;

namespace Sagep.Infra.Data.Mappings
{
    public class ApplicationUserMap : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("UserId");

            builder
                .HasMany(c => c.ApplicationUserRoles)
                .WithOne(d => d.ApplicationUser)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();
            
            builder
                .HasMany(c => c.ApplicationUserClaims)
                .WithOne()
                .HasForeignKey(c => c.UserId)
                .IsRequired();
            
             builder
                .HasOne(c => c.Tenant)
                .WithMany(c => c.ApplicationUsers)
                .HasForeignKey(c => c.TenantId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(c => c.TelefoneCelular)
                .HasDefaultValue(99999999999)
                .HasMaxLength(20);

            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                new ApplicationUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                    FullName = "Alan Rezende",
                    UserName = "alan.rezendeeee@hotmail.com",
                    NormalizedUserName = "ALAN.REZENDEEEE@HOTMAIL.COM",
                    Avatar = "/images/avatars/1.png",
                    Email = "alan.rezendeeee@hotmail.com",
                    NormalizedEmail = "ALAN.REZENDEEEE@HOTMAIL.COM",
                    ConcurrencyStamp = "ca431822-360a-4ee6-b978-66564d429fc7",
                    SecurityStamp = "c9514850-61dd-4cc1-b909-88b79b035643",
                    EmailConfirmed = true,
                    LockoutEnabled = true,
                    PasswordHash = "AQAAAAEAACcQAAAAEFqndd0aQiH3EC2qn6j21zHj1rZKlwofwEpNhCLuA7EQsV3Fvv+S1HuJ0snxDruE8w==",
                    TenantId = null
                }
            );
        }
    }
}