using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMobile.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Director { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
