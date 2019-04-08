using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetQuax.Models
{
  public class UserDetailsModel
  {
    private int _userId;
    private NetQuax.Entities.User _user;

    public UserDetailsModel(int _userId)
    {
      _userId = _userId;
      _user = null;
    }

    public NetQuax.Entities.User User
    {
      get
      {
        if(_user== null && _userId > 0)
        {
          _user = new NetQuax.Entities.User(_userId);
        }
        return _user;
      }
    }
  }
}