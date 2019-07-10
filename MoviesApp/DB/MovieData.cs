using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MoviesApp.DB
{
    public class MovieData
    {
        public static List<Movie> m_Movies { get; set; }
        public static List<Movie> Movies()
        {
            if (m_Movies == null)
            {
                using (StreamReader r = new StreamReader(Path.Combine(HttpContext.Current.Server.MapPath("~"),"DB/MovieData.json")))
                {
                    string json = r.ReadToEnd();
                    m_Movies = JsonConvert.DeserializeObject<List<Movie>>(json);
                }
                /*m_Movies = new List<Movie>();
                m_Movies.Add(new Movie()
                {
                    id = 9,
                    Title = "DC's Legends of Tomorrow",
                    Image = "..\\Images\\DCs-Legends.jpg",
                    Seasons = 2,
                    Views = 21,
                    IsSeries = true
                });*/
            }
            return m_Movies;

        }
    }
}