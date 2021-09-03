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

        public Command AddEmailCommand { get; }
        public Command DeleteCommand { get; }
        public Command SelectCommand { get; }

        async void OnWriteEmail()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddEmailPage(Emails));
        }

        void OnDelete(Email email)
        {
            Emails.Remove(email);
        }

        public EmailListViewModel()
        {
            AddEmailCommand = new Command(OnWriteEmail);
            DeleteCommand = new Command<Email>(OnDelete);
        }
    }
}
