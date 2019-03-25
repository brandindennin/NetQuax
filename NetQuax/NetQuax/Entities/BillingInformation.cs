using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetQuax.Entities
{
  public class BillingInformation : IBillingInformation
  {
        #region fields
        private int _billingID;
        private int _cardNumber;
        private int _expDate;
        private int _securityCode;
        private string _cardName;
        #endregion
    }
    public BillingInformation(int billingID)
    {
        _billingID = billingID;
        _cardNumber = null;
        _expDate = null;
        _securityCode = null;
        _cardName = null;
    }
    public int cardNumber
    {
        get
        {
            if (_title == null)
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
    public int expDate
    {
        get
        {
            if (_title == null)
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
    public int securityCode
    {
        get
        {
            if (_title == null)
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
    public string cardName
    {
        get
        {
            if (_title == null)
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