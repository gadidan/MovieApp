using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesApp.DB
{
    public class Movie
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int Seasons { get; set; }
        public long Views { get; set; }
        public bool  IsSeries{ get; set; }
    }
}