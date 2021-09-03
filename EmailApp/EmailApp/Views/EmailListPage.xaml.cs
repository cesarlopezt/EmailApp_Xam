using EmailApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmailApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailListPage : ContentPage
    {
        public EmailListPage()
        {
            InitializeComponent();
            this.BindingContext = new EmailListViewModel();
        }
    }
}