using NetQuax.Entities;
using System.Collections.Generic;

namespace NetQuax.Models
{
  public class SearchModel
  {
    private List<Movie> _foundMovies;

    public SearchModel(List<Movie> movies)
    {
      _foundMovies = movies;
    }

    public List<Movie> Movies
    {
      get
      {
        return _foundMovies;
      }
    }
  }
}