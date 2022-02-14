using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Navigations
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        async void Previous_Click(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        //ilk sayfaya atar.
        async void First_Click(Object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}