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
      //And many more
    }

    public string Title
    {
      get
      {
        if(_title == null && _movieId > 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT nameOfMovie from MOVIES WHERE movieId = {0}", _movieId);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              _title = (string)reader[0];
            }
            conn.Close();
          }
        }
        return _title;
      }
    }

    public string Director
    {
      get
      {
        if (_director == null && _movieId > 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT director from MOVIES WHERE movieId = {0}", _movieId);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              _director = (string)reader[0];
            }
            conn.Close();
          }
        }
        //TODO: Replace this with matching data
        return _director;
      }
    }

    public string Description
    {
      get
      {
        if (_description == null && _movieId > 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT Description from MOVIES WHERE movieId = {0}", _movieId);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              _description = (string)reader[0];
            }
            conn.Close();
          }
        }
        //TODO: Replace this with matching data
        return _description;
      }
    }
    #endregion
  }
}