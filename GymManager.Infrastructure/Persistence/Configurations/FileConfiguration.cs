using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = GymManager.Domain.Entities.File;

namespace GymManager.Infrastructure.Persistence.Configurations;

public class FileConfiguration : IEntityTypeConfiguration<File>
{
    public void Configure(EntityTypeBuilder<File> builder)
    {
        builder.ToTable("Files");

        builder.Property(f => f.Name)
            .HasMaxLength(300)
            .IsRequired();

        builder.Property(f => f.Description)
            .IsRequired();
    }
}
