using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.ViewModels;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiplePreSelection : ContentPage
    {
        public MultiplePreSelection()
        {
            InitializeComponent();
            BindingContext = new MovieViewModel();
        }
    }
}