using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamarinMobile.Models
{
    public class MovieGroup : ObservableCollection<Movie>
    {
        public string Title { get; set; }
        public string ShortName { get; set; }
        public MovieGroup(string title, string shortname)
        {
            Title = title; ShortName = shortname;
        }
    }
}
