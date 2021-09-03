using System;
using System.Collections.Generic;
using System.Text;

namespace EmailApp.Models
{
    class Email
    {
        public Email(string to, string from, string subject, string body)
        {
            To = to;
            From = from;
            Subject = subject;
            Body = body;
            SentAt = DateTime.Now;
        }

        public string To { get; set; }
        public string From { get; set; }
        public DateTime SentAt { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
