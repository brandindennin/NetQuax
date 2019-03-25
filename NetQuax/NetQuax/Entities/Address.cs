using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetQuax.Entities
{
  public class Address : IAddress
  {
        #region fields
        private int _addressID;
        private string _addressLine1;
        private string _addressLine2;
        private string _city;
        private string _state;
        private int _zip;
        private int _userIDFK;
        private int _addressIDFK;
        #endregion

        #region constructor
        public Address(int addressID)
        {
            _addressLine1 = null;
            _addressLine2 = null;
            _city = null;
            _state = null;
            _zip = null;

        }
        public string addressLine1
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
        public string addressLine2
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
        public string city
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
        public string state
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
        public int zip
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
}