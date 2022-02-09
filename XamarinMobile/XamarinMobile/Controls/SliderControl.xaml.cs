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
    public partial class SliderControl : ContentPage
    {
        public SliderControl()
        {
            InitializeComponent();
        }

        void Handle_Changed(object sender, ValueChangedEventArgs e)
        {
            //e.NewValue;
            //slider.Value;
            double value = ((Slider)sender).Value;
        }
    }
}