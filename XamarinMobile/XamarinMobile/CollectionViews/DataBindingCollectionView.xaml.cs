﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Models;

namespace XamarinMobile.CollectionViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBindingCollectionView : ContentPage
    {
        public DataBindingCollectionView()
        {
            InitializeComponent();

            var movies = new List<Movie>
            {
                new Movie{Id=1,Name="Name 1",Director="Director 1",Raiting=4.1,ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 2",Director="Director 2",Raiting=4.8,ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 3",Director="Director 3",Raiting=4.7,ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 4",Director="Director 4",Raiting=3.1,ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"},
                new Movie{Id=1,Name="Name 5",Director="Director 5",Raiting=3.4,ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"},
                new Movie{Id=1,Name="Name 6",Director="Director 6",Raiting=4.2,ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"},
                new Movie{Id=1,Name="Name 3",Director="Director 3",Raiting=4.7,ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 2",Director="Director 2",Raiting=4.8,ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 2",Director="Director 2",Raiting=4.8,ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg"},
                new Movie{Id=1,Name="Name 4",Director="Director 4",Raiting=3.1,ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"},
                new Movie{Id=1,Name="Name 6",Director="Director 6",Raiting=4.2,ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg"}
            };

            movieList.ItemsSource = movies;
        }
    }
}