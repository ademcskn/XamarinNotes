using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Models;

namespace XamarinMobile.DataBindings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotifyProperyChangedDemo : ContentPage
    {
        public NotifyProperyChangedDemo()
        {
            InitializeComponent();

            //Yöntem 1, yöntem 2 xaml tarafında binding ederek.
            //BindingContext = new NotifyViewModel();
        }
    }
}