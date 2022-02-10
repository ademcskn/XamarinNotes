using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Models;

namespace XamarinMobile.Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupingItems : ContentPage
    {
        List<MovieGroup> movieGroup = new List<MovieGroup>();
        public GroupingItems()
        {
            InitializeComponent();
            movieGroup.Add(new MovieGroup("Komedi", "K")
            {
                new Movie{Id=1,Name="Name 1",Director="Director 1",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 2",Director="Director 2",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 3",Director="Director 3",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 4",Director="Director 4",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"},
                new Movie{Id=1,Name="Name 5",Director="Director 5",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"},
                new Movie{Id=1,Name="Name 6",Director="Director 6",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"}
            });

            movieGroup.Add(new MovieGroup("Macera", "M")
            {
                new Movie{Id=1,Name="Name 1",Director="Director 1",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 2",Director="Director 2",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 3",Director="Director 3",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 4",Director="Director 4",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"},
                new Movie{Id=1,Name="Name 5",Director="Director 5",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"},
                new Movie{Id=1,Name="Name 6",Director="Director 6",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"}
            });

            movieGroup.Add(new MovieGroup("Belgeseller", "B")
            {
                new Movie{Id=1,Name="Name 1",Director="Director 1",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 2",Director="Director 2",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 3",Director="Director 3",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 4",Director="Director 4",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"},
                new Movie{Id=1,Name="Name 5",Director="Director 5",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"},
                new Movie{Id=1,Name="Name 6",Director="Director 6",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"}
            });

            listview.ItemsSource = movieGroup;
        }
    }
}