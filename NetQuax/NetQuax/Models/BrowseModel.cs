using NetQuax.Entities;
using System.Collections.Generic;

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
        for (int i = 1; i < 19; i++)
        {
          // get the first 3 movies from the database
          NetQuax.Entities.Movie movie = new NetQuax.Entities.Movie(i);
          _browseMovies.Add(movie);
        }
        return _browseMovies;
      }
    }
  }
}