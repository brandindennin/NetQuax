using System.Collections.Generic;
using System.Data.SqlClient;

namespace NetQuax.Entities
{
  public class MovieList : IMovieList
  {
    private List<Movie> _allMovies;

    public MovieList()
    {
      _allMovies = new List<Movie>();
    }

    public List<Movie> AllMovies
    {
      get
      {
        if (_allMovies.Count == 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT movieId from MOVIES");
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              Movie movie = new Movie((long)reader[0]);
              _allMovies.Add(movie);
            }
            conn.Close();
          }
        }
        return _allMovies;
      }
    }
  }
}