using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Infrastructure.Persistence.Extensions;

public static class ModelBuilderExtensionsAnnouncement
{
    public static void SeedAnnouncement(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Announcement>().HasData(
            new Announcement
            {
                Id = 1,
                Date = new DateTime(2022, 1, 12),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio nec nunc"

            },
            new Announcement
            {
                Id = 2,
                Date = new DateTime(2022, 1, 13),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio nec nunc"
            },
            new Announcement
            {
                Id = 3,
                Date = new DateTime(2022, 1, 14),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio nec nunc"
            },
            new Announcement
            {
                Id = 4,
                Date = new DateTime(2022, 1, 15),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio nec nunc"
            },
            new Announcement
            {
                Id = 5,
                Date = new DateTime(2022, 1, 16),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio nec nunc"
            },
            new Announcement
            {
                Id = 6,
                Date = new DateTime(2022, 1, 17),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio nec nunc"
            },
            new Announcement
            {
                Id = 7,
                Date = new DateTime(2022, 1, 18),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio nec nunc"
            },
            new Announcement
            {
                Id = 8,
                Date = new DateTime(2022, 1, 19),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio nec nunc"
            },
            new Announcement
            {
                Id = 9,
                Date = new DateTime(2022, 1, 20),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio nec nunc"
            },
            new Announcement
            {
                Id = 10,
                Date = new DateTime(2022, 1, 21),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio nec nunc"
            },
            new Announcement
            {
                Id = 11,
                Date = new DateTime(2022, 1, 22),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio nec nunc"
            },
            new Announcement
            {
                Id = 12,
                Date = new DateTime(2022, 1, 23),
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec odio nec nunc"
            }
        );
    }
}
