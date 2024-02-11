using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistence.Configurations;

public class EmployeeEventConfiguration : IEntityTypeConfiguration<EmployeeEvent>
{
    public void Configure(EntityTypeBuilder<EmployeeEvent> builder)
    {
        builder.ToTable("EmployeeEvents");

        builder.Property(ee => ee.UserId)
            .IsRequired();

        builder
            .HasOne(ee => ee.User)
            .WithMany(u => u.EmployeeEvents)
            .HasForeignKey(ee => ee.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
