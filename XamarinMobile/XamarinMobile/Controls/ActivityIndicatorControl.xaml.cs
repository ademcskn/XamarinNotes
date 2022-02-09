using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityIndicatorControl : ContentPage
    {
        public ActivityIndicatorControl()
        {
            InitializeComponent();

            var imageSource = new UriImageSource
            {
                Uri = new Uri("https://images.pexels.com/photos/5084163/pexels-photo-5084163.jpeg"),
                CachingEnabled = false
            };
            image.Source = imageSource;
        }
    }
}