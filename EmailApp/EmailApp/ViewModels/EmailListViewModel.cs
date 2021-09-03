using EmailApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace EmailApp.ViewModels
{
    class EmailListViewModel : BaseViewModel
    {
        public ObservableCollection<Email> Emails { get; set; } = new ObservableCollection<Email>()
        {
            new Email("Dani", "Cesar", "Secreto", "Te amo"),
            new Email("Dani", "Cesar", "Secreto", "Te amo")
        };

        public Command AddEmailCommand { get; }
        public Command DeleteCommand { get; }

        void OnAddEmail()
        {
            Emails.Add(new Email("Dani", "Cesar", "Secreto", "Te amo"));
        }

        void OnDelete(Email email)
        {
            Emails.Remove(email);
        }

        public EmailListViewModel()
        {
            AddEmailCommand = new Command(OnAddEmail);
            DeleteCommand = new Command<Email>(OnDelete);
        }
    }
}
