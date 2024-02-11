using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistence.Configurations;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.ToTable("Languages");

        builder.Property(l => l.Name)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(l => l.Key)
            .HasMaxLength(5)
            .IsRequired();
    }
}
