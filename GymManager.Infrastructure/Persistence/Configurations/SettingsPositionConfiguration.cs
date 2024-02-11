using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistence.Configurations;

public class SettingsPositionConfiguration : IEntityTypeConfiguration<SettingsPosition>
{
    public void Configure(EntityTypeBuilder<SettingsPosition> builder)
    {
        builder.ToTable("SettingsPositions");

        builder.Property(sp => sp.Key)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(sp => sp.Value)
            .HasMaxLength(1000);

        builder.Property(sp => sp.Description)
            .HasMaxLength(200)
            .IsRequired();

        builder
            .HasOne(sp => sp.Settings)
            .WithMany(s => s.Positions)
            .HasForeignKey(sp => sp.SettingsId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}