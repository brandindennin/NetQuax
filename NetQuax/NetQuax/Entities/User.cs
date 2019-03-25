using System.Data.SqlClient;

namespace NetQuax.Entities
{
  public class User : IUser
  {
    #region fields

    private int _activeMovies;
    private string _addressId;
    private string _password;
    private int _userId;
    private string _username;
    private string _userType;

    #endregion

    public User(int userId)
    {
      _userId = userId;
      _username = null;
      _password = null;
      _userType = null;
      _activeMovies = int.MinValue;
      _addressId = null;
    }

    public string activeMovies
    {
      get
      {
        if (_activeMovies <= 0 && _userId > 0)
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

    public string addressId
    {
      get
      {
        if (_addressId == null && _userId > 0)
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

    public string password
    {
      get
      {
        if (_password == null && _userId > 0)
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

    public string username
    {
      get
      {
        if (_username == null && _userId > 0)
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

    public string userType
    {
      get
      {
        if (_userType == null && _userId > 0)
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
  }
}