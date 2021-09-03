using EmailApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace EmailApp.ViewModels
{
    class AddEmailViewModel : BaseViewModel
    {
        public Command SendEmailCommand { get; }
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public AddEmailViewModel(ObservableCollection<Email> emails)
        {
            SendEmailCommand = new Command(async () =>
            {
                emails.Add(new Email(To, From, Subject, Body));
                await App.Current.MainPage.Navigation.PopAsync();
            });

        }
    }
}
