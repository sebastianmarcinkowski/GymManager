using GymManager.Application.Dictonaries;
using GymManager.Domain.Entities;
using GymManager.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Infrastructure.Persistence.Extensions;

public static class ModelBuilderExtensionsSettingsPosition
{
    public static void SeedSettingsPosition(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SettingsPosition>().HasData(
            new SettingsPosition
            {
                Id = 1,
                Key = SettingsDictionary.HostSmtp,
                Value = "smtp.gmail.com",
                Description = "Host SMTP.",
                Type = SettingsType.Text,
                SettingsId = 1,
                Order = 1
            },
            new SettingsPosition
            {
                Id = 2,
                Key = SettingsDictionary.Port,
                Value = "587",
                Description = "Port.",
                Type = SettingsType.Integer,
                SettingsId = 1,
                Order = 2
            },
            new SettingsPosition
            {
                Id = 3,
                Key = SettingsDictionary.SenderEmail,
                Value = "",
                Description = "E-mail nadawcy.",
                Type = SettingsType.Text,
                SettingsId = 1,
                Order = 3
            },
            new SettingsPosition
            {
                Id = 4,
                Key = SettingsDictionary.SenderEmailPassword,
                Value = "",
                Description = "Hasło nadawcy.",
                Type = SettingsType.Password,
                SettingsId = 1,
                Order = 4
            },
            new SettingsPosition
            {
                Id = 5,
                Key = SettingsDictionary.SenderName,
                Value = "Sebastian Marcinkowski",
                Description = "Nazwa nadawcy.",
                Type = SettingsType.Text,
                SettingsId = 1,
                Order = 5
            },
            new SettingsPosition
            {
                Id = 6,
                Key = SettingsDictionary.SenderLogin,
                Value = "",
                Description = "Login nadawcy.",
                Type = SettingsType.Text,
                SettingsId = 1,
                Order = 6
            },
            new SettingsPosition
            {
                Id = 7,
                Key = SettingsDictionary.BannerVisible,
                Value = "True",
                Description = "Czy wyświetlać banner na stronie głównej?",
                Type = SettingsType.Boolean,
                SettingsId = 2,
                Order = 1
            },
            new SettingsPosition
            {
                Id = 8,
                Key = SettingsDictionary.FooterColor,
                Value = "#dc3545",
                Description = "Kolor stopki strony głównej.",
                Type = SettingsType.Color,
                SettingsId = 2,
                Order = 2
            },
            new SettingsPosition
            {
                Id = 9,
                Key = SettingsDictionary.AdminEmail,
                Value = "kontakt@sebastianmarcinkowski.pl",
                Description = "Główny adres e-mail administratora.",
                Type = SettingsType.Text,
                SettingsId = 2,
                Order = 3
            }
        );
    }
}
