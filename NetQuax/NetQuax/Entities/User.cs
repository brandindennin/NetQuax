using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetQuax.Entities
{
    public class User : IUser
    {
        #region fields
        private string _username;
        private string _password;
        private string _addressID;
        private int _userID;
        private string _userType;
        private string _activeMovies;
        #endregion

        public User(int userID)
        {
            _userID = userID;
            _username = null;
            _password = null;
            _userType = null;
            _activeMovies = null;
            _addressID = null;
        }
        public string username
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
        public string password
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
        public string userType
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
    public string addressID
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
    public string activeMovies
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