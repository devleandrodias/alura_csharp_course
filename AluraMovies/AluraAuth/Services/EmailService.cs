using AluraAuth.Models;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using System;

namespace AluraAuth.Services
{
    public class EmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void SendEmail(string[] destiny, string subject, int userId, string confirmationCode)
        {
            Message message = new(destiny, subject, userId, confirmationCode);

            MimeMessage emailMessage = CreateEmailBody(message);

            Send(emailMessage);
        }

        private MimeMessage CreateEmailBody(Message message)
        {
            string from = _configuration.GetValue<string>("EmailSettings:From");

            MimeMessage emailMessage = new();

            emailMessage.From.Add(MailboxAddress.Parse(from));
            emailMessage.To.AddRange(message.Destiny);
            emailMessage.Subject = message.Subject;

            emailMessage.Body = new TextPart(TextFormat.Text)
            {
                Text = message.Content
            };

            return emailMessage;
        }

        private void Send(MimeMessage message)
        {
            using var client = new SmtpClient();

            try
            {
                string host = _configuration.GetValue<string>("EmailSettings:SmtpServer");

                int port = _configuration.GetValue<int>("EmailSettings:Port");

                client.Connect(host, port, true);

                client.AuthenticationMechanisms.Remove("XOUATH2");

                string from = _configuration.GetValue<string>("EmailSettings:From");

                string password = _configuration.GetValue<string>("EmailSettings:Password");

                client.Authenticate(from, password);

                client.Send(message);
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }
    }
}
