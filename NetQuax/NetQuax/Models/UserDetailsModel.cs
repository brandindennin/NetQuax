namespace NetQuax.Models
{
  public class UserDetailsModel
  {
    private long _userId;
    private NetQuax.Entities.User _user;

    public UserDetailsModel(long _userId)
    {
      _userId = _userId;
      _user = null;
    }

    public NetQuax.Entities.User User
    {
      get
      {
        if (_user == null && _userId > 0)
        {
          _user = new NetQuax.Entities.User(_userId);
        }
        return _user;
      }
    }
  }
}