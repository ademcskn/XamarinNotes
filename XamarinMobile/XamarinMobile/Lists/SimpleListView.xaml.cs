using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleListView : ContentPage
    {
        public SimpleListView()
        {
            InitializeComponent();

            listview.ItemsSource = new string[]
            {
                "item 1",
                "item 2",
                "item 3"
            };
        }
    }
}