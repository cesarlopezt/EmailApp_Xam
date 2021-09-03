using EmailApp.Models;
using EmailApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace EmailApp.ViewModels
{
    class EmailListViewModel : BaseViewModel
    {
        public ObservableCollection<Email> Emails { get; set; } = new ObservableCollection<Email>();
        
        private Email _selectedEmail;
        public Email SelectedEmail
        {
            get => _selectedEmail;
            set
            {
                _selectedEmail = value;
                if(_selectedEmail != null)
                {
                    SelectCommand.Execute(_selectedEmail);
                    SelectedEmail = null;
                }
            }
        }

        public Command AddEmailCommand { get; }
        public Command DeleteCommand { get; }
        public Command SelectCommand { get; }

        async void OnWriteEmail()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddEmailPage(Emails));
        }

        async void OnOpenEmail(Email email)
        {
            await App.Current.MainPage.DisplayAlert("HELLO", email.Subject, "ok");
            await App.Current.MainPage.Navigation.PushAsync(new EmailDetailPage(email));
        }

        void OnDelete(Email email)
        {
            Emails.Remove(email);
        }

        public EmailListViewModel()
        {
            AddEmailCommand = new Command(OnWriteEmail);
            DeleteCommand = new Command<Email>(OnDelete);
            SelectCommand = new Command<Email>(OnOpenEmail);
        }
    }
}
