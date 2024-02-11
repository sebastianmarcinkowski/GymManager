using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistence.Configurations;

public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.ToTable("Invoices");

        builder.Property(i => i.MethodOfPayment)
            .HasMaxLength(20)
            .IsRequired();

        builder.Property(i => i.UserId)
            .IsRequired();

        builder.Property(i => i.TicketId)
            .IsRequired();

        builder
            .HasOne(i => i.User)
            .WithMany(u => u.Invoices)
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
