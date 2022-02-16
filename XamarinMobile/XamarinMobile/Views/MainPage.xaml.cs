using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public ICommand NavigateCommand { get; set; }
        public MainPage()
        {
            InitializeComponent();

            NavigateCommand = new Command<Type>(
                async (Type pageType) =>
           {
               Page page = (Page)Activator.CreateInstance(pageType);
               await Navigation.PushAsync(page);
           });

            //NavigateCommand nesnesi gibi public nesnelere Xaml tarafında ulaşmak için BindingContext e atamasını yapmamız gerekiyor.
            BindingContext = this;
        }
    }
}