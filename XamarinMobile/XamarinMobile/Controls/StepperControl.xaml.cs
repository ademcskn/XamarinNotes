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
    public partial class StepperControl : ContentPage
    {
        public StepperControl()
        {
            InitializeComponent();
        }


        void Handle_Changed(object sender, ValueChangedEventArgs e)
        {
            //e.NewValue;
            //stepper.Value;
            double value = ((Stepper)sender).Value;
        }
    }
}