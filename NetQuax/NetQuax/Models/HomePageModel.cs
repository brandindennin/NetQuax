using NetQuax.Entities;
using System.Collections.Generic;

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
    private List<Movie> _featuredMovies2;
    private List<Movie> _featuredMovies3;
    private List<Movie> _saleMovies;
    private List<Movie> _saleMovies2;
    private List<Movie> _saleMovies3;
    private List<Movie> _chosenMovies;
    private List<Movie> _chosenMovies2;
    private List<Movie> _chosenMovies3;

    public HomePageModel()
    {
      _featuredMovies = new List<Movie>();
      _featuredMovies2 = new List<Movie>();
      _featuredMovies3 = new List<Movie>();
      _saleMovies = new List<Movie>();
      _saleMovies2 = new List<Movie>();
      _saleMovies3 = new List<Movie>();
      _chosenMovies = new List<Movie>();
      _chosenMovies2 = new List<Movie>();
      _chosenMovies3 = new List<Movie>();
    }

    //This will not work until we get the rest of the movies into the database
    public List<Movie> FeaturedMovies
    {
      get
      {
        for (int i = 1; i < 4; i++)
        {
          // get the first 3 movies from the database
          NetQuax.Entities.Movie movie = new NetQuax.Entities.Movie(i);
          _featuredMovies.Add(movie);
        }
        return _featuredMovies;
      }
    }

    public List<Movie> FeaturedMovies2
    {
      get
      {
        for (int i = 4; i < 7; i++)
        {
          //Get the second three Movies
          NetQuax.Entities.Movie movie = new NetQuax.Entities.Movie(i);
          _featuredMovies2.Add(movie);
        }
        return _featuredMovies2;
      }
    }

    public List<Movie> FeaturedMovies3
    {
      get
      {
        for (int i = 7; i < 10; i++)
        {
          //Get the third three Movies

          NetQuax.Entities.Movie movie = new NetQuax.Entities.Movie(i);
          if (!(_featuredMovies3.Contains(movie)))
          {
            _featuredMovies3.Add(movie);
          }
        }
        return _featuredMovies3;
      }
    }

    public List<Movie> ChosenMovies
    {
      get
      {
        for (int i = 10; i < 13; i++)
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

    public List<Movie> ChosenMovies2
    {
      get
      {
        for (int i = 13; i < 16; i++)
        {
          //Get the third three Movies

          NetQuax.Entities.Movie movie = new NetQuax.Entities.Movie(i);
          if (!(_chosenMovies2.Contains(movie)))
          {
            _chosenMovies2.Add(movie);
          }
        }
        return _chosenMovies2;
      }
    }

    public List<Movie> ChosenMovies3
    {
      get
      {
        for (int i = 16; i < 19; i++)
        {
          //Get the third three Movies

          NetQuax.Entities.Movie movie = new NetQuax.Entities.Movie(i);
          if (!(_chosenMovies3.Contains(movie)))
          {
            _chosenMovies3.Add(movie);
          }
        }
        return _chosenMovies3;
      }
    }

    public List<Movie> SaleMovies
    {
      get
      {
        for (int i = 19; i < 22; i++)
        {
          //Get the third three Movies

          NetQuax.Entities.Movie movie = new NetQuax.Entities.Movie(i);
          if (!(_saleMovies.Contains(movie)))
          {
            _saleMovies.Add(movie);
          }
        }
        return _saleMovies;
      }
    }

    public List<Movie> SaleMovies2
    {
      get
      {
        for (int i = 22; i < 25; i++)
        {
          //Get the third three Movies

          NetQuax.Entities.Movie movie = new NetQuax.Entities.Movie(i);
          if (!(_saleMovies2.Contains(movie)))
          {
            _saleMovies2.Add(movie);
          }
        }
        return _saleMovies2;
      }
    }

    public List<Movie> SaleMovies3
    {
      get
      {
        for (int i = 25; i < 28; i++)
        {
          //Get the third three Movies

          NetQuax.Entities.Movie movie = new NetQuax.Entities.Movie(i);
          if (!(_saleMovies3.Contains(movie)))
          {
            _saleMovies3.Add(movie);
          }
        }
        return _saleMovies3;
      }
    }
  }
}