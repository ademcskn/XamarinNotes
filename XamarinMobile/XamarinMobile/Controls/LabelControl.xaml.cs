using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinMobile.Controls
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelControl : ContentPage
    {
        [Obsolete]
        public ICommand TapCommand => new Command<string>(OpenBrowser);

        public LabelControl()
        {
            InitializeComponent();
            BindingContext = this;
        }

        [Obsolete]
        void OpenBrowser(string url)
        {
            Device.OpenUri(new Uri(url));
        }
    }
}