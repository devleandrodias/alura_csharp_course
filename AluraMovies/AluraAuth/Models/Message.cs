using MimeKit;
using System.Collections.Generic;
using System.Linq;

namespace AluraAuth.Models
{
    public class Message
    {
        public Message(IEnumerable<string> destiny, string subject, int userId, string confirmationCode)
        {
            Destiny = new List<MailboxAddress>();
            Destiny.AddRange(destiny.Select(x => MailboxAddress.Parse(x)));
            Subject = subject;
            Content = $"https://localhost:6001/v1/auth/confirm-email?UserId={userId}&ConfirmationCode={confirmationCode}";
        }

        public List<MailboxAddress> Destiny { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }
    }
}
