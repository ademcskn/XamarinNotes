using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Models;

namespace XamarinMobile.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }
        public SecondPage(string name,Movie movie)
        {
            InitializeComponent();

            lblResult.Text = name;

            BindingContext = movie;
        }

        async void Next_Click(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ThirdPage());
        }

        async void Previous_Click(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}