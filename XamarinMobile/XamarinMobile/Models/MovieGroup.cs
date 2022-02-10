using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMobile.Models
{
    public class MovieGroup : List<Movie>
    {
        public string Title { get; set; }
        public string ShortName { get; set; }
        public MovieGroup(string title, string shortname)
        {
            Title = title; ShortName = shortname;
        }
    }
}
