using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistence.Configurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(au => au.FirstName)
            .HasMaxLength(100);

        builder.Property(au => au.LastName)
            .HasMaxLength(100);

        builder
            .HasOne(au => au.Address)
            .WithOne(a => a.User)
            .HasForeignKey<Address>(a => a.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(au => au.Client)
            .WithOne(c => c.User)
            .HasForeignKey<Client>(c => c.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(au => au.Employee)
            .WithOne(e => e.User)
            .HasForeignKey<Employee>(e => e.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
