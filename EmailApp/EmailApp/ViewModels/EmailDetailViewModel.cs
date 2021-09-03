using EmailApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmailApp.ViewModels
{
    class EmailDetailViewModel : BaseViewModel
    {
        public EmailDetailViewModel(Email email)
        {
            To = email.To;
            From = email.From;
            SentAt = email.SentAt;
            Subject = email.Subject;
            Body = email.Body;
        }
        public string To { get; set; }
        public string From { get; set; }
        public DateTime SentAt { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
