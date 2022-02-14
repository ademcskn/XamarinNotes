using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobile.CollectionViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleCollectionView : ContentPage
    {
        public SimpleCollectionView()
        {
            InitializeComponent();

            products.ItemsSource = new String[]
            {
                "Samsung s5",
                "Samsung s6",
                "Samsung s7",
                "Samsung s8",
                "Samsung s9",
                "Samsung s10 Plus",
            };
        }
    }
}