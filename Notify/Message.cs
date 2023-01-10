using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Notify
{
    public class Message
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public Message(IEnumerable<string> to, string subject, string content)
        {
            To = new List<MailboxAddress>();

            To.AddRange(to.Select(emailAdress => new MailboxAddress(emailAdress, emailAdress))); //TODO:provide recipient's name instead of emailAddress duplication
            Subject = subject;
            Content = content;
        }
    }
}