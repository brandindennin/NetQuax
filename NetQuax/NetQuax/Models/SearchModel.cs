using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NetQuax.Entities;

namespace NetQuax.Models
{
  public class SearchModel
  {
    List<Movie> _foundMovies;
    
    public SearchModel(List<Movie> movies )
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