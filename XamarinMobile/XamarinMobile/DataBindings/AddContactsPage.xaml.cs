using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Models;

namespace XamarinMobile.DataBindings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactsPage : ContentPage
    {
        //ContactViewModel viewModel;
        public AddContactsPage()
        {
            InitializeComponent();
            BindingContext = new ContactViewModel
            {
                Name = "Adem Coşkun",
                WebSite = "https://twitter.com/ademcskn_",
                Favorite = true,
                Phone = 05412222222
            };
        }
        //async void Button_Clicked(object sender, EventArgs e)
        //{
        //    await Browser.OpenAsync(new Uri(viewModel.WebSite), BrowserLaunchMode.SystemPreferred);
        //}
    }
}