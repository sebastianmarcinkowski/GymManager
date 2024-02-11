using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistence.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");

        builder.Property(e => e.WebsiteUrl)
            .HasMaxLength(200)
            .IsUnicode(false);

        builder.Property(e => e.ImageUrl)
            .HasMaxLength(400);

        builder.Property(e => e.UserId)
            .IsRequired();
    }
}
