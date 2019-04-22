using NetQuax.Entities;
using System.Collections.Generic;

namespace NetQuax.Models
{
  public class BrowseModel
  {
    // TODO: Browse Model needs a list of every movie, use Home Model as example
    private MovieList _browseMovies;

    public BrowseModel()
    {
      _browseMovies = new MovieList();
    }

    public MovieList BrowseMovies
    {
      get
      {
        return _browseMovies;
      }
    }
  }
}