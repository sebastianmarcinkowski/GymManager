using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistence.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Addresses");

        builder.Property(a => a.Country)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(a => a.City)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(a => a.Street)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(a => a.StreetNumber)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(a => a.ZipCode)
            .HasMaxLength(10)
            .IsRequired();

        builder.Property(a => a.UserId)
            .IsRequired();
    }
}
