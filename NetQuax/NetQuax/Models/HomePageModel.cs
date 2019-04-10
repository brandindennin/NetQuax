using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NetQuax.Entities;

namespace NetQuax.Models
{
  public class HomePageModel
  {
    /* Models contain all database data that we need for the view.
       For Example, the home page will contain a list of featured movies
       sale movies, and chosen movies, 3 for each row to start. So
       we intitialize 3 lists of movie objects. We retrieve movies from the database
       using the entities we developed from before. One we retrieve the movies we can make them 
       accessible to the associated view
     */ 
    private List<Movie> _featuredMovies;
    private List<Movie> _saleMovies;
    private List<Movie> _chosenMovies;
    public HomePageModel()
    {
      _featuredMovies = new List<Movie>();
      _saleMovies = new List<Movie>();
      _chosenMovies = new List<Movie>();
    }

    //This will not work until we get the rest of the movies into the database
    public List<Movie> FeaturedMovies
    {
      get
      {
        for(int i = 1; i < 4; i++)
        {
          // get the first 3 movies from the database
          NetQuax.Entities.Movie movie = new NetQuax.Entities.Movie(i);
          _featuredMovies.Add(movie);          
        }
        return _featuredMovies;
      }
    }

    public List<Movie> SaleMovies
    {
      get
      {
        for(int i = 4; i < 7; i++ )
        {
          //Get the second three Movies
          NetQuax.Entities.Movie movie = new NetQuax.Entities.Movie(i);
          _saleMovies.Add(movie);
        }
        return _saleMovies;
        
      }
    }

    public List<Movie> ChosenMovies
    {
      get
      {
        for(int i = 7; i < 10; i++ )
        {
          //Get the third three Movies
          
          NetQuax.Entities.Movie movie = new NetQuax.Entities.Movie(i);
          if (!(_chosenMovies.Contains(movie)))
          {
            _chosenMovies.Add(movie);
          }
        }
        return _chosenMovies;
      }
    }

  }
}