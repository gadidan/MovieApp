using MoviesApp.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MoviesApp.Controllers
{
    public class MovieController : ApiController
    {
        List<Movie> m_movies = MovieData.Movies();

        // GET: api/Movie 
        public IQueryable<Movie> Get()
        {
            return m_movies.AsQueryable();
        }

        // GET: api/Movie/5  
        [ResponseType(typeof(Movie))]
        public IHttpActionResult Get(int id)
        {
            var movie = m_movies.Where(m => m.id == id).FirstOrDefault();
            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie);
        }
    }
}
