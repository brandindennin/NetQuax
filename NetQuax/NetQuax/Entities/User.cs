using System.Data.SqlClient;

namespace NetQuax.Entities
{
  public class User : IUser
  {
    #region fields

    private int _activeMovies;
    private long _addressId;
    private string _password;
    private int _userId;
    private string _username;
    private long _userType;

    #endregion fields

    public User(int userId)
    {
      _userId = userId;
      _username = username(userId);
      _password = password(userId);
      _userType = userType(userId);
     // _activeMovies = activeMovies(userId);
      _addressId = addressId(userId);
    }






    /* RETRIEVING THE USERNAME FROM THE DATABASE */

    public string username(int _userId)
    {
      // if the userId is valid, continue
      if (_userId > 0)
      {
        //use the SQL data reader class to read data from sql server
        SqlDataReader reader = null;

        //set up the connection string using the connection string from the github readme file
        using (SqlConnection conn = new SqlConnection(Globals.connectionString))
        {
          //open the connection
          conn.Open();

          // This string is just a sql query, it can be any query, but you will have to change
          // the SqlDataReader to something else, check the microsoft docs if youre curious
          string queryString = string.Format("SELECT userName from USERS WHERE userId = {0}", _userId);

          // using the sql query and the connection we defined, create a sql commanf object
          SqlCommand cmd = new SqlCommand(queryString, conn);

          // send the command to the database
          reader = cmd.ExecuteReader();

          // while there's information, read. Since we are only expecting one value back from the database, this is 
          // just an assignment. The information cmes back serverside as an array with values of each row returned by the db.
          // Since we are only selecting the user name the array only contains the username at index 0
          while (reader.Read())
          {
            _username = (string)reader[0];
          }

          //close the connection
          conn.Close();          
        }       
      }
      //return the retrieved username;
      return _username;
    }






    public long addressId(int _userId)
    {
      if ( _userId > 0)
      {
        SqlDataReader reader = null;
        //TODO: build out sql connection
        using (SqlConnection conn = new SqlConnection(Globals.connectionString))
        {
          conn.Open();
          string queryString = string.Format("SELECT userAddressId from USERS WHERE userId = {0}", _userId);
          SqlCommand cmd = new SqlCommand(queryString, conn);
          reader = cmd.ExecuteReader();
          while (reader.Read())
          {
            _addressId = (long)reader[0];
          }
          conn.Close();
        }
      }
      //TODO: Replace this with matching data
      return _addressId;
    }

    public string password(int _userId)
    {
      if (_userId > 0)
      {
        SqlDataReader reader = null;
        using (SqlConnection conn = new SqlConnection(Globals.connectionString))
        {
          conn.Open();
          string queryString = string.Format("SELECT userPassword from USERS WHERE userId = {0}", _userId);
          SqlCommand cmd = new SqlCommand(queryString, conn);
          reader = cmd.ExecuteReader();
          while (reader.Read())
          {
            _password = (string)reader[0];
          }
          conn.Close();
        }
      }
      //TODO: Replace this with matching data
      return _password ;
    }

 

    public long userType(int _userId)
    {
      if (_userId > 0)
      {
        SqlDataReader reader = null;
        //TODO: build out sql connection
        using (SqlConnection conn = new SqlConnection(Globals.connectionString))
        {
          conn.Open();
          string queryString = string.Format("SELECT userTypeId from USERS WHERE userId = {0}", _userId);
          SqlCommand cmd = new SqlCommand(queryString, conn);
          reader = cmd.ExecuteReader();
          while (reader.Read())
          {
            _userType = (long)reader[0];
          }
          conn.Close();
        }
      }
      //TODO: Replace this with matching data
      return _userType;
    }

    /*public int activeMovies(int _userId)
    {
      if (_activeMovies <= 0 && _userId > 0)
      {
        //TODO: build out sql connection
        SqlDataReader reader = null;
        using (SqlConnection conn = new SqlConnection(Globals.connectionString))
        {
          //TODO: Retrieve matching movie data from db
        }
      }
      //TODO: Replace this with matching data
      return 1;
    }*/


    public Address GetAddressByUser(int userId)
    {
      return null;
    }

    public BillingInformation GetBillingInformationByUser(int userId)
    {
      return null;
    }
  }
}