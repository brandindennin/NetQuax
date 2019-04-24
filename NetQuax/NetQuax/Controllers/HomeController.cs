using NetQuax.Entities;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using System.Data.SqlClient;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace NetQuax.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      //NetQuax.Entities.User user = new NetQuax.Entities.User(1);
      return View("Index", new NetQuax.Models.HomePageModel());
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }

    public ActionResult Browse()
    {
      return View("BeginBrowsePage", new NetQuax.Models.BrowseModel());
    }

    /// <summary cref="User" >">
    /// Adds A new user based upon inputs from add user form
    /// </summary>
    /*public ActionResult AddUser(FormCollection form)
    {
      string detectedUserName = string.Empty;
      string detectedPassword = string.Empty;
      string detectedPasswordConfirmation = string.Empty;
      string detectedAddressLine1 = string.Empty;
      string detectedAddressLine2 = string.Empty;
      string detectedZip = string.Empty;
      string detectedState = string.Empty;
      string detectedCity = string.Empty;
      string detectedCardIssuer = string.Empty;
      string detectedCardName = string.Empty;
      string detectedCardNumber = string.Empty;
      string detectedExpDate = string.Empty;
      string detectedCVV = string.Empty;
      string errorMessage = string.Empty;
      bool errorFlag = false;
      if (form != null)
      {
        if (form.AllKeys.Contains("UserName"))
        {
          detectedUserName = form["UserName"];
        }
        if (form.AllKeys.Contains("Password"))
        {
          detectedPassword = form["Password"];
        }
        if (form.AllKeys.Contains("PasswordConfirmation"))
        {
          detectedPasswordConfirmation = form["PasswordConfirmation"];
        }
        if (form.AllKeys.Contains("AddressLine1"))
        {
          detectedAddressLine1 = form["AddressLine1"];
        }
        if (form.AllKeys.Contains("AddressLine2"))
        {
          detectedAddressLine1 = form["AddressLine2"];
        }
        if (form.AllKeys.Contains("Zip"))
        {
          detectedAddressLine1 = form["Zip"];
        }
        if (form.AllKeys.Contains("State"))
        {
          detectedAddressLine1 = form["State"];
        }
        if (form.AllKeys.Contains("City"))
        {
          detectedAddressLine1 = form["City"];
        }
        if (form.AllKeys.Contains("CardIssuer"))
        {
          detectedAddressLine1 = form["CardIssuer"];
        }
        if (form.AllKeys.Contains("CardName"))
        {
          detectedAddressLine1 = form["CardName"];
        }
        if (form.AllKeys.Contains("ExpDate"))
        {
          detectedExpDate = form["ExpDate"];
        }
        if (form.AllKeys.Contains("CardNumber"))
        {
          detectedAddressLine1 = form["CardNumber"];
        }
        if (form.AllKeys.Contains("CVV"))
        {
          detectedAddressLine1 = form["CVV"];
        }
      }

      if (detectedUserName == string.Empty)
      {
        errorFlag = true;
        errorMessage = "Username is required";
      }

      if (detectedPassword == string.Empty)
      {
        //TODO: Error
      }
      if (detectedPasswordConfirmation == string.Empty)
      {
        //TODO: Error
      }
      if (detectedPasswordConfirmation != detectedPassword)
      {
        //TODO: Error
      }
      if (!errorFlag)
      
      {
        using (SqlConnection conn = new SqlConnection(Globals.connectionString))
        {
            conn.Open();
            string queryString = string.Format("INSERT INTO CREDITCARD VALUES (CardNumber, ExpDate, CVV, CardIssuer)");
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                _cardHolder = (string)reader[0];
            }
            conn.Close();
        }

        using (SqlConnection conn = new SqlConnection(Globals.connectionString))
        {
          conn.Open();
          string queryString = string.Format("INSERT INTO ADDRESSES VALUES (AddressLine1, AddressLine2, City, State, Zip)");
          SqlCommand cmd = new SqlCommand(queryString, conn);
          reader = cmd.ExecuteReader();
          while (reader.Read())
          {
            _cardHolder = (string)reader[0];
          }
          conn.Close();
        }
        //TODO: return home view

        //TODO: Credit Card and Address Key
        //Session["User"] = newUser;
        /*using (SqlConnection conn = new SqlConnection(Globals.connectionString))
        {
            conn.Open();
            string queryString = string.Format("INSERT INTO USERS VALUES (userName, userPassword, isAdmin, userAddressId, userTypeId, userCCInfo)");
            SqlCommand cmd = new SqlCommand(queryString, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                _cardHolder = (string)reader[0];
            }
            conn.Close();
        }*/
        //TODO: return home view
      /*}
      else
      {
        //TODO: Return Error View
      }
      return View("Index", new NetQuax.Models.HomePageModel());
    }*/

    // Method to be called when user checks out a movie
    public ActionResult Checkout(FormCollection form)
    {
      string errorMessage = string.Empty;
      bool errorFlag = false;
      string detectedMovieId = string.Empty;
      string detectedUserId = string.Empty;
      if (form != null)
      {
        if (form.AllKeys.Contains("MovieId"))
        {
          detectedMovieId = form["MovieId"];
        }
        if (form.AllKeys.Contains("UserId"))
        {
          detectedUserId = form["UserId"];
        }
      }
      long movieId = long.MinValue;
      long.TryParse(detectedMovieId, out movieId);
      if (movieId <= 0)
      {
        errorFlag = true;
        errorMessage = "Error: Movie does not exist!";
      }

      long userId = long.MinValue;
      long.TryParse(detectedUserId, out userId);
      if (userId <= 0)
      {
        //TODO: errorChecking
      }

      if (!errorFlag)
      {
        //TODO modify userdb to reflect changes
        //TODO return home view
      }
      else
      {
        //Don't update db
        //return error view
      }
      return null;
    }

    public JsonResult SignIn(FormCollection form)
    {
      string detectedUserName = string.Empty;
      string detectedPassword = string.Empty;
      string errorMessage = string.Empty;
      bool errorFlag = false;
      bool isSignedIn = false ;

      if (form != null)
      {
        if(form.AllKeys.Contains("Username"))
        {
          detectedUserName = form["Username"];
        }
        if(form.AllKeys.Contains("Password"))
        {
          detectedPassword = form["Password"];
        }
      }      

      if (detectedUserName == string.Empty)
      {
        errorFlag = true;
        errorMessage = "Username is required";
      }
      if (detectedPassword == string.Empty)
      {
        errorMessage = "Password is required";
      }
      if (!errorFlag)
      {
        isSignedIn = ValidateUser(detectedUserName, detectedPassword);
        if(isSignedIn)
        {
          errorMessage = "Successfully signed in!";
        }
        else
        {
          errorMessage = "Error signing in, check your credentials.";
        }
      }
      return Json(new
      {
        ErrorMessage = errorMessage,
        Valid = isSignedIn
      });
    }

    public bool ValidateUser(string username, string password)
    {
      bool valid = false;
      string detectedPassword = string.Empty;
      long detectedUserId = long.MinValue;
      SqlDataReader reader = null;
      using (SqlConnection conn = new SqlConnection(Globals.connectionString))
      {
        conn.Open();
        string queryString = string.Format("SELECT userPassword, userId from USERS WHERE userName = '{0}'", username);
        SqlCommand cmd = new SqlCommand(queryString, conn);
        reader = cmd.ExecuteReader();
        while (reader.Read())
        {
          detectedPassword = (string)reader[0];
          detectedUserId = (long)reader[1];
        }

        conn.Close();
      }
      if (detectedPassword == password)
      {
        valid = true;
        Session["User"] = username;
        Session["UserId"] = detectedUserId;
      }
      return valid;
    }

    public JsonResult SearchMovies(FormCollection form)
    {
      string detectedSearchString = string.Empty;
      string detectedCategory = string.Empty;
      List<Movie> filteredMovies = new List<Movie>();
      if(form != null)
      {
        if(form.AllKeys.Contains("SearchString"))
        {
          detectedSearchString = form["SearchString"];
        }
        if(form.AllKeys.Contains("SearchCategory"))
        {
          detectedCategory = form["SearchCategory"];
        }
      }

      MovieList movies = new MovieList();

      if(detectedCategory == "Actor")
      {
        foreach(Movie m in movies.AllMovies.Where(x => x.Actor.ToLower().Trim().Contains(detectedSearchString.ToLower().Trim())) )
        {
          Movie newMovie = new Movie(m.MovieId);
          filteredMovies.Add(newMovie);
        }
      }
      if (detectedCategory == "Title")
      {
        foreach (Movie m in movies.AllMovies.Where(x => x.Title.ToLower().Trim().Contains(detectedSearchString.ToLower().Trim())))
        {
          Movie newMovie = new Movie(m.MovieId);
          filteredMovies.Add(newMovie);
        }
      }
      if (detectedCategory == "Genre")
      {
        foreach (Movie m in movies.AllMovies.Where(x => x.Title.ToLower().Trim().Contains(detectedSearchString.ToLower().Trim())))
        {
          Movie newMovie = new Movie(m.MovieId);
          filteredMovies.Add(newMovie);
        }
      }



      string html = RenderRazorViewToString("/Views/Home/_browseMoviesPartial.cshtml", new NetQuax.Models.SearchModel(filteredMovies));
      return Json(new { Html = html });
    }

    public JsonResult SearchByActor(FormCollection form)
    {
      return null;
    }

    public JsonResult SearchByGenre(FormCollection form)
    {
      return null;
    }

    public ActionResult SignOut()
    {
      Session["UserName"] = null;
      //TODO return home view
      return null;
    }

    public string RenderRazorViewToString(string viewName, object model)
    {
      ViewData.Model = model;
      using (var sw = new StringWriter())
      {
        var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext,
                                                                 viewName);
        var viewContext = new ViewContext(ControllerContext, viewResult.View,
                                     ViewData, TempData, sw);
        viewResult.View.Render(viewContext, sw);
        viewResult.ViewEngine.ReleaseView(ControllerContext, viewResult.View);
        return sw.GetStringBuilder().ToString();
      }
    }
  }

}