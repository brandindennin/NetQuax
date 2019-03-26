using System.Data.SqlClient;

namespace NetQuax.Entities
{
  public class Address : IAddress
  {
    #region fields

    private int _addressId;
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
      _userId = int.MinValue;
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
        return _addressLine1;
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
        return _addressLine2;
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
        return _city;
      }
    }

    public string State
    {
      get
      {
        if (_state == null && _addressId > 0)
        {
          //TODO: build out sql connection
          using (SqlConnection conn = new SqlConnection())
          {
            //TODO: Retrieve matching movie data from db
          }
        }
        //TODO: Replace this with matching data
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