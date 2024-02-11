using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistence.Configurations;

public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.ToTable("Tickets");

        builder.Property(t => t.UserId)
            .IsRequired();

        builder.Property(t => t.TicketTypeId)
            .HasDefaultValue(1);

        builder
            .HasOne(t => t.User)
            .WithMany(u => u.Tickets)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(t => t.TicketType)
            .WithMany(tt => tt.Tickets)
            .HasForeignKey(t => t.TicketTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne(t => t.Invoice)
            .WithOne(i => i.Ticket)
            .HasForeignKey<Invoice>(i => i.TicketId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
