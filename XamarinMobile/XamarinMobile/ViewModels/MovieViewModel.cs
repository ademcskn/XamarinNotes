using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMobile.Models;

namespace XamarinMobile.ViewModels
{
    public class MovieViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Movie> Movies { get; set; }
        public Movie SelectedMovie { get; set; }
        public ObservableCollection<object> SelectedMovies { get; set; }
        public string SelectedMovieName { get; set; }
        public ICommand MovieSelectionChangedCommand => new Command(MovieSelectionChanged);
        public MovieViewModel()
        {
            Movies = new ObservableCollection<Movie>
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

            SelectedMovie = Movies[2];
            MovieSelectionChanged();
            SelectedMovies = new ObservableCollection<object>
            {
                Movies[0],Movies[3],Movies[4]
            };
        }
        void MovieSelectionChanged()
        {
            SelectedMovieName = "Seçilen film : " + SelectedMovie.Name;
            OnPropertyChanged("SelectedMovieName");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
