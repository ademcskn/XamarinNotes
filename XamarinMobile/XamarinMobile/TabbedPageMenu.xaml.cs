using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Navigations;

namespace XamarinMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageMenu : TabbedPage
    {
        public TabbedPageMenu()
        {
            InitializeComponent();

            //this.Children.Add(new ContentPage());
            //this.Children.Add(new FirstPage());
            //this.Children.Add(new NavigationPage(new FirstPage()));
        }
    }
}