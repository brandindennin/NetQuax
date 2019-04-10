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
        private float _rating;
        private string _actor;
        private string _mode;
        private int _yearReleased;
        #endregion

        #region constructor
        public Movie(int movieId)
        {
            _movieId = movieId;
            _title = null;
            _director = null;
            _description = null;
            _price = int.MinValue;
            _rating = int.MinValue;
            _actor = null;
            _mode = null;
            _yearReleased = int.MinValue;
            //And many more
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
        #endregion

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
                            _title = (string)reader[0];
                        }
                        conn.Close();
                    }
                }
                return _title;
            }
        }
        public float Rating
        {
            get
            {
                if (_title == null && _movieId > 0)
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
                            _title = (string)reader[0];
                        }
                        conn.Close();
                    }
                }
                return int.MinValue;
            }
        }
        public int Price
        {
            get
            {
                if (_title == null && _movieId > 0)
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
                            _title = (string)reader[0];
                        }
                        conn.Close();
                    }
                }
                return int.MinValue;
            }
        }
        public string YearReleased
        {
            get
            {
                if (_title == null && _movieId > 0)
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
                            _title = (string)reader[0];
                        }
                        conn.Close();
                    }
                }
                return _title;
            }
        }
        public string Mode
        {
            get
            {
                if (_title == null && _movieId > 0)
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
                            _title = (string)reader[0];
                        }
                        conn.Close();
                    }
                }
                return _title;
            }
        }

    }
}