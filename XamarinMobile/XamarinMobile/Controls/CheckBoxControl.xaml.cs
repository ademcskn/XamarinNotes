using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CheckBoxControl : ContentPage
    {
        public CheckBoxControl()
        {
            InitializeComponent();
        }

        void Handle_Changed(object sender, CheckedChangedEventArgs e)
        {
            var result = e.Value.ToString();
            lblResult.Text = result;
        }
    }
}