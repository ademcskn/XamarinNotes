
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageControl : ContentPage
    {
        public ImageControl()
        {
            InitializeComponent();
            //var imageSource = new UriImageSource
            //{
            //    Uri = new Uri("https://picsum.photos/800/600"),
            //     CachingEnabled = false,
            //     CacheValidity = new TimeSpan(2,0,0,0,0)
            //};
            //image.Source = imageSource;

            //image.Source = ImageSource.FromResource("XamarinMobile.Images.pexels-image.jpg");


            image.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("adememre.jpg") : ImageSource.FromFile("pexelsimage.jpg");
            image.Aspect = Aspect.AspectFill;
        }
    }
}