using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace NetQuax.Entities
{
  public class Movie : IMovie
  {
    #region fields
    private string _title;
    private string _director;
    private int _movieId;
    private string _description;
    private int _price;

    #endregion

    #region constructor
    public Movie(int movieId)
    {
      _movieId = movieId;
      _title = null;
      _director = null;
      _description = null;
    }

    public string Title
    {
      get
      {
        if(_title == null)
        {
          //TODO: build out sql connection
          using (SqlConnection conn = new SqlConnection())
          {
            //TODO: Retrieve matching movie data from db
          }
        }
        //TODO: Replace this with matching data
        return null;
      }
    }

    public string Director
    {
      get
      {
        if (_director == null)
        {
          //TODO: build out sql connection
          using (SqlConnection conn = new SqlConnection())
          {
            //TODO: Retrieve matching movie data from db
          }
        }
        //TODO: Replace this with matching data
        return null;
      }
    }

    public string Description
    {
      get
      {
        if (_description == null)
        {
          //TODO: build out sql connection
          using (SqlConnection conn = new SqlConnection())
          {
            //TODO: Retrieve matching movie data from db
          }
        }
        //TODO: Replace this with matching data
        return null;
      }
    }
    #endregion
  }
}