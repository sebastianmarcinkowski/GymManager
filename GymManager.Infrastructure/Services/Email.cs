﻿using GymManager.Application.Common.Interfaces;
using GymManager.Application.Dictonaries;
using MailKit.Net.Smtp;
using MimeKit;

namespace GymManager.Infrastructure.Services;

public class Email : IEmail
{
    private string _hostSmtp;

    private int _port;

    private string _senderEmail;

    private string _SenderEmailPassword;

    private string _senderName;

    private string _senderLogin;

    public async Task Update(IAppSettingsService appSettingsService)
    {
        _hostSmtp = await appSettingsService.Get(SettingsDictionary.HostSmtp);

        _port = Convert.ToInt32(await appSettingsService.Get(SettingsDictionary.Port));

        _senderEmail = await appSettingsService.Get(SettingsDictionary.SenderEmail);

        _SenderEmailPassword = await appSettingsService.Get(SettingsDictionary.SenderEmailPassword);

        _senderName = await appSettingsService.Get(SettingsDictionary.SenderName);

        _senderLogin = await appSettingsService.Get(SettingsDictionary.SenderLogin);
    }

    public async Task SendAsync(string subject, string body, string to, string attachmentPath = null)
    {
        var message = new MimeMessage();

        message.From.Add(new MailboxAddress(_senderName, _senderEmail));

        message.To.Add(MailboxAddress.Parse(to));

        message.Subject = subject;

        var builder = new BodyBuilder();

        builder.HtmlBody = @$"
        <html>
            <head>
            </head>
            <body>
                <div style=""font-size: 16px; padding: 10px; font-family: Arial; line-height: 1.4;"">
                    {body}
                </div>
            </body>
        </html>
        ";

        if (!string.IsNullOrEmpty(attachmentPath))
            builder.Attachments.Add(attachmentPath);

        message.Body = builder.ToMessageBody();

        using (var client = new SmtpClient())
        {
            await client.ConnectAsync(
                _hostSmtp,
                _port,
                MailKit.Security.SecureSocketOptions.Auto);

            await client.AuthenticateAsync(
                !string.IsNullOrWhiteSpace(_senderLogin) ? _senderLogin : _senderEmail,
                _SenderEmailPassword);

            await client.SendAsync(message);

            await client.DisconnectAsync(true);
        }
    }
}
