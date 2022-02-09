using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.DataBindings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicBindings : ContentPage
    {
        public BasicBindings()
        {
            InitializeComponent();

            //Yöntem 1
            //label.BindingContext = slider;
            //label.SetBinding(Label.RotationProperty, "Value");

            //Yöntem 2
            //label.SetBinding(Label.RotationProperty, new Binding("Value", source: slider));

            //Yöntem3 = Xaml da labela binding işlemi yaparak
        }
    }
}