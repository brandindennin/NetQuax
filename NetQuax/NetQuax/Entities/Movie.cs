using System.Data.SqlClient;

namespace NetQuax.Entities
{
  public class Movie : IMovie
  {
    #region fields

    private string _title;
    private string _director;
    private long _movieId;
    private string _description;
    private decimal _price;
    private long _rating;
    private string _actor;
    private string _mode;
    private string _genre;
    private long _yearReleased;

    #endregion fields

    #region constructor

    public Movie(long movieId)
    {
      _movieId = movieId;
      _title = null;
      _genre = null;
      _director = null;
      _description = null;
      _price = int.MinValue;
      _rating = int.MinValue;
      _actor = null;
      _mode = null;
      _yearReleased = int.MinValue;
      //And many more
    }

    public string Genre
    {
      get
      {
        if (_title == null && _movieId > 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT genre from MOVIES WHERE movieId = {0}", _movieId);
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

    public string Title
    {
      get
      {
        if (_title == null && _movieId > 0)
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
        return _description;
      }
    }

    public long MovieId
    {
      get
      {
        return _movieId;
      }
    }

    #endregion constructor

    public string Actor
    {
      get
      {
        if (_title == null && _movieId > 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT actors from MOVIES WHERE movieId = {0}", _movieId);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              _actor = (string)reader[0];
            }
            conn.Close();
          }
        }
        return _actor;
      }
    }

    /* public string Director
     {
       get
       {
         if (_title == null && _movieId > 0)
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
         return _director;
       }
     }*/

    public long Rating
    {
      get
      {
        if (_rating <= 0 && _movieId > 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT rating from MOVIES WHERE movieId = {0}", _movieId);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              _rating = (long)reader[0];
            }
            conn.Close();
          }
        }
        return _rating;
      }
    }

    public decimal Price
    {
      get
      {
        if (_price <= 0 && _movieId > 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT price from MOVIES WHERE movieId = {0}", _movieId);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              _price = (decimal)reader[0];
            }
            conn.Close();
          }
        }
        return _price;
      }
    }

    public long YearReleased
    {
      get
      {
        if (_yearReleased <= 0 && _movieId > 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT yearReleased from MOVIES WHERE movieId = {0}", _movieId);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              _yearReleased = (long)reader[0];
            }
            conn.Close();
          }
        }
        return _yearReleased;
      }
    }

    public string Mode
    {
      get
      {
        if (_mode == null && _movieId > 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT movieMode from MOVIES WHERE movieId = {0}", _movieId);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              _mode = (string)reader[0];
            }
            conn.Close();
          }
        }
        return _mode;
      }
    }
  }
}