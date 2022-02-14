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
    public partial class TableViewMenu : ContentPage
    {
        public TableViewMenu()
        {
            InitializeComponent();
        }

        async void navigateToPage(object sender, EventArgs e)
        {
            string type = (string)(sender as TextCell).CommandParameter;

            Type pageType = Type.GetType("XamarinMobile.Navigations." + type + ",XamarinMobile");

            Page page = (Page)Activator.CreateInstance(pageType);
            await Navigation.PushAsync(page);
        }
    }
}