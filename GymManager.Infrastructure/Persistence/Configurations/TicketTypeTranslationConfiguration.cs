using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManager.Infrastructure.Persistence.Configurations;

public class TicketTypeTranslationConfiguration
    : IEntityTypeConfiguration<TicketTypeTranslation>
{
    public void Configure(EntityTypeBuilder<TicketTypeTranslation> builder)
    {
        builder.ToTable("TicketTypeTranslations");

        builder.Property(ttt => ttt.Name)
            .IsRequired();

        builder
            .HasOne(ttt => ttt.Language)
            .WithMany(l => l.TicketTypeTranslations)
            .HasForeignKey(ttt => ttt.LanguageId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
