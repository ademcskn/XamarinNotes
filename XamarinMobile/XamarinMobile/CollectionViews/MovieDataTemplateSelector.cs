using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinMobile.Models;

namespace XamarinMobile.CollectionViews
{
    public class MovieDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MovieDataTemplate { get; set; }
        public DataTemplate PopulerMovieDataTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var movie = item as Movie;
            if (movie.Raiting > 4.1)
            {
                return PopulerMovieDataTemplate;
            }
            return MovieDataTemplate;
        }
    }
}
