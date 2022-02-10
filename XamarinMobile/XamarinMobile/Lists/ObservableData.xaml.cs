using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Models;

namespace XamarinMobile.Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObservableData : ContentPage
    {
        ObservableCollection<Movie> movies = new ObservableCollection<Movie>();
        public ObservableData()
        {
            InitializeComponent();

            movies.Add(new Movie { Id = 1, Director = "Director 1", Name = "Name 1", ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg" });
            movies.Add(new Movie { Id = 2, Director = "Director 2", Name = "Name 2", ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg" });
            movies.Add(new Movie { Id = 3, Director = "Director 3", Name = "Name 3", ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg" });

            listview.ItemsSource = movies;
        }

        private void Handle_AddMovie(object sender, EventArgs e)
        {
            movies.Add(new Movie { Id = 4, Director = "Director 4", Name = "Name 4", ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg" });
            lblCount.Text = movies.Count.ToString();
        }

        private void Handle_RemoveMovie(object sender, EventArgs e)
        {
            movies.RemoveAt(movies.Count - 1);
            lblCount.Text = movies.Count.ToString();
        }
    }
}