using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace NetQuax.Entities
{
  public class MovieList : IMovieList
  {
    List<Movie> _allMovies;

    public MovieList ()
    {
      _allMovies = new List<Movie>();
    }
  }
}