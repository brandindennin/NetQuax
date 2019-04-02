using System.Data.SqlClient;

namespace NetQuax.Entities
{
  public class Address : IAddress
  {
    #region fields

    private int _addressId;
    private string _addressLineOne;
    private string _addressLineTwo;
    private string _city;
    private string _state;
    private int _userId;
    private string _zip;

    #endregion fields

    #region constructor

    public Address(int addressId)
    {
      _addressLineOne = null;
      _addressLineTwo = null;
      _city = null;
      _state = null;
      _zip = null;
      _addressId = addressId;
      _userId = int.MinValue;
    }

    #endregion constructor

    public string AddressLine1
    {
      get
      {
        if (_addressLineOne == null && _addressId > 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT AddressLineOne from ADDRESSES WHERE addressId = {0}", _addressId);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              _addressLineOne = (string)reader[0];
            }
            conn.Close();
          }
        }        
        return _addressLineOne;
      }
    }

    public string AddressLine2
    {
      get
      {
        if (_addressLineTwo == null && _addressId > 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT AddressLineTwo from ADDRESSES WHERE addressId = {0}", _addressId);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              _addressLineTwo = (string)reader[0];
            }
            conn.Close();
          }
        }       
        return _addressLineTwo;
      }
    }

    public string City
    {
      get
      {
        if (_city == null && _addressId > 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT city from ADDRESSES WHERE addressId = {0}", _addressId);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              _city= (string)reader[0];
            }
            conn.Close();
          }
        }
        return _city;
      }
    }

    public string State
    {
      get
      {
        if (_state == null && _addressId > 0)
        {
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT state from ADDRESSES WHERE addressId = {0}", _addressId);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              _state = (string)reader[0];
            }
            conn.Close();
          }
        }
        return _state;
      }
    }

    public string Zip
    {
      get
      {
        if (_zip == null && _addressId > 0)
        {
          //TODO: build out sql connection
          SqlDataReader reader = null;
          using (SqlConnection conn = new SqlConnection(Globals.connectionString))
          {
            conn.Open();
            string queryString = string.Format("SELECT zipCode from ADDRESSES WHERE addressId = {0}", _addressId);
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              _zip = (string)reader[0];
            }
            conn.Close();
          }
        }        
        return _zip;
      }
    }
  }
}
