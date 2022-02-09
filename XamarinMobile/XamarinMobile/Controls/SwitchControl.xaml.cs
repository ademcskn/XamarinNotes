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
    public partial class SwitchControl : ContentPage
    {
        public SwitchControl()
        {
            InitializeComponent();
        }
        void Handle_Toggle(object sender, ToggledEventArgs e)
        {
            lblResult.Text = e.Value.ToString();
        }
    }

}