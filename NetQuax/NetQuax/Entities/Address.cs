using System.Data.SqlClient;

namespace NetQuax.Entities
{
  public class Address : IAddress
  {
    #region fields

    private int _addressId;
    private int _addressID;
    private string _addressLine1;
    private string _addressLine2;
    private string _city;
    private string _state;
    private int _userId;
    private string _zip;

    #endregion

    #region constructor

    public Address(int addressId)
    {
      _addressLine1 = null;
      _addressLine2 = null;
      _city = null;
      _state = null;
      _zip = null;
      _addressId = addressId;
    }
    #endregion
    public string AddressLine1
    {
      get
      {
        if (_addressLine1 == null && _addressId > 0)
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

    public string AddressLine2
    {
      get
      {
        if (_addressLine2 == null && _addressId > 0)
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

    public string City
    {
      get
      {
        if (_city == null && _addressId > 0)
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

    public string State
    {
      get
      {
        if (_state == null)
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

    public string Zip
    {
      get
      {
        if (_zip == null)
        {
          //TODO: build out sql connection
          using (SqlConnection conn = new SqlConnection())
          {
            //TODO: Retrieve matching movie data from db
          }
        }
        //TODO: Replace this with matching data
        return _zip;
      }
    }
  }
}