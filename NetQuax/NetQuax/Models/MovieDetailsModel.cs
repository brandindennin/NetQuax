using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetQuax.Models
{
  public class MovieDetailsModel
  {
    private int _movieId;
    private NetQuax.Entities.Movie _movie;

    public MovieDetailsModel(int movieId)
    {
      _movieId = movieId;
      _movie = null;
    }

    public NetQuax.Entities.Movie Movie
    {
      get
      {
        if(_movieId > 0 && _movie == null)
        {
          _movie = new NetQuax.Entities.Movie(_movieId);
        }
        return _movie;
      }
    }

    public int MovieId
    {
      get
      {
        return _movieId;
      }
    }
  }
}