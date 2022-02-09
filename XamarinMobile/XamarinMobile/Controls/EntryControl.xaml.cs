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
    public partial class EntryControl : ContentPage
    {
        public EntryControl()
        {
            InitializeComponent();
        }

        void Handle_Changed(object sender, TextChangedEventArgs e)
        {
            labelText.Text = e.NewTextValue;
        }

        void Handle_Completed(object sender, EventArgs e)
        {
            labelText.Text = "Changed";
        }
    }
}