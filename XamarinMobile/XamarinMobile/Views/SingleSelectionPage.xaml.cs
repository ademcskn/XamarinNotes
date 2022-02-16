using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Models;
using XamarinMobile.ViewModels;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SingleSelectionPage : ContentPage
    {
        public SingleSelectionPage()
        {
            InitializeComponent();

            BindingContext = new MovieViewModel();
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var previous = (e.PreviousSelection.FirstOrDefault() as Movie)?.Name;
            var current = (e.CurrentSelection.FirstOrDefault() as Movie)?.Name;


            lblCurrent.Text = current;
            lblPrevious.Text = previous;
        }
    }
}