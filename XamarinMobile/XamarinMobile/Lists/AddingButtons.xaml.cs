﻿using System;
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
    public partial class AddingButtons : ContentPage
    {
        List<MovieGroup> movieGroup = new List<MovieGroup>();

        public AddingButtons()
        {
            InitializeComponent();

            movieGroup.Add(new MovieGroup("Komedi", "K")
            {
                new Movie{Id=1,Name="Name 1",Director="Director 1",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg",Description="Description 1"},
                new Movie{Id=1,Name="Name 2",Director="Director 2",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg",Description="Description 2"},
                new Movie{Id=1,Name="Name 3",Director="Director 3",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg",Description="Description 3"},
                new Movie{Id=1,Name="Name 4",Director="Director 4",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg",Description="Description 4"},
                new Movie{Id=1,Name="Name 5",Director="Director 5",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg",Description="Description 5"},
                new Movie{Id=1,Name="Name 6",Director="Director 6",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg",Description="Description 6"}
            });

            movieGroup.Add(new MovieGroup("Macera", "M")
            {
                new Movie{Id=1,Name="Name 1",Director="Director 1",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg",Description="Description 1"},
                new Movie{Id=1,Name="Name 2",Director="Director 2",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg",Description="Description 2"},
                new Movie{Id=1,Name="Name 3",Director="Director 3",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg",Description="Description 3"},
                new Movie{Id=1,Name="Name 4",Director="Director 4",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg",Description="Description 4"},
                new Movie{Id=1,Name="Name 5",Director="Director 5",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg",Description="Description 5"},
                new Movie{Id=1,Name="Name 6",Director="Director 6",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg",Description="Description 6"}
            });

            movieGroup.Add(new MovieGroup("Belgeseller", "B")
            {
                new Movie{Id=1,Name="Name 1",Director="Director 1",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg",Description="Description 1"},
                new Movie{Id=1,Name="Name 2",Director="Director 2",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg",Description="Description 2"},
                new Movie{Id=1,Name="Name 3",Director="Director 3",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/1VCRVaBObV3ZLDuuYQHCs87NBmi.jpg",Description="Description 3"},
                new Movie{Id=1,Name="Name 4",Director="Director 4",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg",Description="Description 4"},
                new Movie{Id=1,Name="Name 5",Director="Director 5",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg",Description="Description 5"},
                new Movie{Id=1,Name="Name 6",Director="Director 6",ImageUrl="https://www.themoviedb.org/t/p/w220_and_h330_face/bcCBq9N1EMo3daNIjWJ8kYvrQm6.jpg",Description="Description 6"}
            });

            listview.ItemsSource = movieGroup;

        }
        void ListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Movie;
            var itemIndex = e.SelectedItemIndex;
            lblResult.Text += item.Name + " " + "is selected. \n";
            lblResult.Text += "item index: " + itemIndex.ToString() + "\n";
        }

        void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Movie;
            var itemIndex = e.ItemIndex;
            var group = e.Group as MovieGroup;
            lblResult.Text += item.Name + " " + "IsBusy tapped. \n";
            lblResult.Text += "item index: " + itemIndex.ToString() + "\n";
            lblResult.Text += "group name : " + group.Title + "\n";
            lblResult.Text += "\n";
        }

        void DisplayMovieDetails(object sender, EventArgs e)
        {
            var btn = sender as Button;
            //kullanıcı hangi butona tıkladıysa onun movie bilgisine erişek için xaml tarafında CommandParameter da . dedik.
            var movie = btn.CommandParameter as Movie;

            DisplayAlert(movie.Name, movie.Description, "OK");
        }
    }
}