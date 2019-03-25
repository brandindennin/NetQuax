using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace NetQuax.Entities
{
  public class BillingInformation : IBillingInformation
  {
    #region fields

    private int _billingInformationId;
    private string _cardHolder;
    private string _cardNumber;
    private string _expDate;
    private int _securityCode;

    #endregion

    public BillingInformation(int billingId)
    {
      _billingInformationId = billingId;
      _cardNumber = null;
      _expDate = null;
      _securityCode = int.MinValue;
      _cardHolder = null;
    }

    public string CardHolder
    {
      get
      {
        if (_cardHolder == null && _billingInformationId > 0)
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

    public string CardNumber
    {
      get
      {
        if (_cardNumber == null && _billingInformationId > 0)
        {
          //TODO: build out sql connection
          using (SqlConnection conn = new SqlConnection())
          {
            //TODO: Retrieve matching movie data from db
          }
        }
        //TODO: Replace this with matching data
        return _cardNumber;
      }
    }

    public string ExpDate
    {
      get
      {
        if (_expDate == null && _billingInformationId > 0)
        {
          //TODO: build out sql connection
          using (SqlConnection conn = new SqlConnection())
          {
            //TODO: Retrieve matching movie data from db
          }
        }
        //TODO: Replace this with matching data
        return _expDate;
      }
    }

    public int SecurityCode
    {
      get
      {
        if (_securityCode <= 0 && _billingInformationId > 0)
        {
          //TODO: build out sql connection
          using (SqlConnection conn = new SqlConnection())
          {
            //TODO: Retrieve matching movie data from db
          }
        }
        //TODO: Replace this with matching data
        return _securityCode;
      }
    }
  }
}