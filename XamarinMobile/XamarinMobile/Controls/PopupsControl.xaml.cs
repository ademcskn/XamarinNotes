using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupsControl : ContentPage
    {
        public PopupsControl()
        {
            InitializeComponent();
        }

        async void displayAlert(object sender, EventArgs e)
        {
            await DisplayAlert("Title", "Message Body", "Ok");
        }


        async void getResponse(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Title", "Message Body", "Yes", "No");

            lblResult.Text = answer ? "Yes" : "No";
        }

        async void getString(object sender, EventArgs e)
        {
            string answer = await DisplayActionSheet("Send to?", "Cancel", "Delete", "Email", "Twitter", "Instagram");

            lblResult.Text = answer;
        }
    }
}