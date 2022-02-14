using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Navigations
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPageSample : CarouselPage
    {
        public CarouselPageSample()
        {
            InitializeComponent();

            ContentPage page = null;
            for (int i = 1; i <= 10; i++)
            {
                page = new ContentPage();
                page.Content = new Label() { Text = "Page " + i, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
                this.Children.Add(page);
            }
        }
    }
}