using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NetQuax.Entities;

namespace NetQuax.Models
{
  public class BrowseModel
  {
        // TODO: Browse Model needs a list of every movie, use Home Model as example
        private List<Movie> _browseMovies;
        public BrowseModel()
        {
            _browseMovies = null;
        }
        public List<Movie> BrowseMovies
        {
            get
            {
                /*for(int i = 1; i < 100; i++)
                {
                  // get the first 3 movies from the database
                  NetQuax.Entities.Movie movie = new NetQuax.Entities.Movie(i);
                  _featuredMovies.Add(movie);


                }
                return _browseMovies;*/
                return null;
            }
        }
    }
}