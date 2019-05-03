using NetQuax.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Data;

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
    public ActionResult AddUser(FormCollection form)
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
        if (form.AllKeys.Contains("Username"))
        {
          detectedUserName = form["Username"];
        }
        if (form.AllKeys.Contains("Password"))
        {
          detectedPassword = form["Password"];
        }
        if (form.AllKeys.Contains("PasswordConfirmation"))
        {
          detectedPasswordConfirmation = form["PasswordConfirmation"];
        }
        /*if (form.AllKeys.Contains("AddressLine1"))
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
        }*/
      }

      if (detectedUserName == string.Empty)
      {
        errorFlag = true;
        errorMessage = "Username is required";
      }

      if (detectedPassword == string.Empty)
      {
        errorFlag = true;
      }
      if (detectedPasswordConfirmation == string.Empty)
      {
        errorFlag = true;

      }
      if (detectedPasswordConfirmation != detectedPassword)
      {
        errorFlag = true;
      }
      if (!errorFlag)

      {
        using (SqlConnection conn = new SqlConnection(Globals.connectionString))
        {
          conn.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = conn;
          cmd.CommandText = "INSERT INTO Users (userName, userPassword, isAdmin, userAddressId, UserTypeId,userCCInfo) VALUES (@param1,@param2, @param3, @param4, @param5, @param6)";
          cmd.Parameters.Add("@param1", SqlDbType.VarChar).Value = detectedUserName;
          cmd.Parameters.Add("@param2", SqlDbType.VarChar).Value = detectedPassword;
          cmd.Parameters.Add("@param3", SqlDbType.Bit).Value = 0;
          cmd.Parameters.Add("@param4", SqlDbType.BigInt).Value = long.MinValue;
          cmd.Parameters.Add("@param5", SqlDbType.BigInt).Value = long.MinValue;
          cmd.Parameters.Add("@param6", SqlDbType.BigInt).Value = long.MinValue;
          cmd.ExecuteNonQuery();
          conn.Close();
        }
      }
      return RedirectToAction("Index");
    }

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

      return View("Index", new NetQuax.Models.HomePageModel());

    }

    public JsonResult SignIn(FormCollection form)
    {
      string detectedUserName = string.Empty;
      string detectedPassword = string.Empty;
      string errorMessage = string.Empty;
      bool errorFlag = false;
      bool isSignedIn = false;

      if (form != null)
      {
        if (form.AllKeys.Contains("Username"))
        {
          detectedUserName = form["Username"];
        }
        if (form.AllKeys.Contains("Password"))
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
        if (isSignedIn)
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
      string detectedFilter = string.Empty;
      string html = string.Empty;
      List<Movie> filteredMovies = new List<Movie>();
      if (form != null)
      {
        if (form.AllKeys.Contains("SearchString"))
        {
          detectedSearchString = form["SearchString"];
        }
        if (form.AllKeys.Contains("SearchCategory"))
        {
          detectedCategory = form["SearchCategory"];
        }
        if (form.AllKeys.Contains("FilterCategory"))
        {
          detectedFilter = form["FilterCategory"];
        }
      }

      MovieList movies = new MovieList();

      if (detectedCategory == "Actor")
      {
        foreach (Movie m in movies.AllMovies.Where(x => x.Actor.ToLower().Trim().Contains(detectedSearchString.ToLower().Trim())))
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
        foreach (Movie m in movies.AllMovies.Where(x => x.Genre.ToLower().Trim().Contains(detectedSearchString.ToLower().Trim())))
        {
          Movie newMovie = new Movie(m.MovieId);
          filteredMovies.Add(newMovie);
        }
      }
      if (detectedCategory == "Director")
      {
        foreach (Movie m in movies.AllMovies.Where(x => x.Director.ToLower().Trim().Contains(detectedSearchString.ToLower().Trim())))
        {
          Movie newMovie = new Movie(m.MovieId);
          filteredMovies.Add(newMovie);
        }
      }
      if (detectedCategory == "Theme")
      {
        foreach (Movie m in movies.AllMovies.Where(x => x.Genre.ToLower().Trim().Contains(detectedSearchString.ToLower().Trim())))
        {
          Movie newMovie = new Movie(m.MovieId);
          filteredMovies.Add(newMovie);
        }
      }

      List<Movie> furtherFilteredMovie = new List<Movie>();

      if (detectedFilter != "")
      {
        if (detectedFilter == "Decade8")
        {
          foreach (NetQuax.Entities.Movie m in filteredMovies.Where(x => x.YearReleased >= 1980 && x.YearReleased < 1990))
          {
            furtherFilteredMovie.Add(m);
          }
        }
        if (detectedFilter == "Decade9")
        {
          foreach (NetQuax.Entities.Movie m in filteredMovies.Where(x => x.YearReleased >= 1990 && x.YearReleased < 2000))
          {
            furtherFilteredMovie.Add(m);
          }
        }
        if (detectedFilter == "Decade20")
        {
          foreach (NetQuax.Entities.Movie m in filteredMovies.Where(x => x.YearReleased >= 2000))
          {
            furtherFilteredMovie.Add(m);
          }
        }
        if (detectedFilter == "Price")
        {
          foreach (NetQuax.Entities.Movie m in filteredMovies.Where(x => x.Price < 5))
          {
            furtherFilteredMovie.Add(m);
          }
        }
        if (detectedFilter == "Review")
        {
          foreach (NetQuax.Entities.Movie m in filteredMovies.Where(x => x.Rating >= 7))
          {
            furtherFilteredMovie.Add(m);
          }
        }
      }
      if (detectedFilter != "")
      {
        html = RenderRazorViewToString("/Views/Home/_browseMoviesPartial.cshtml", new NetQuax.Models.SearchModel(furtherFilteredMovie));
      }
      else
      {
        html = RenderRazorViewToString("/Views/Home/_browseMoviesPartial.cshtml", new NetQuax.Models.SearchModel(filteredMovies));
      }

      return Json(new { Html = html });
    }
    public ActionResult SignOut()
    {
      Session["UserName"] = null;

      Session["User"] = null;

      return RedirectToAction("Index");
    }

    public ActionResult AddToCart(FormCollection form)
    {
      string detectedMovieId = string.Empty;
      if (Session["Cart"] == null)
      {
        Session["Cart"] = new List<Movie>();
      }
      if (form != null)
      {
        if (form.AllKeys.Contains("MovieId"))
        {
          detectedMovieId = form["MovieId"];
        }
      }

      long MovieId = long.MinValue;
      long.TryParse(detectedMovieId, out MovieId);

      if (MovieId > 0)
      {
        List<Movie> temp = (List<Movie>)Session["Cart"];
        temp.Add(new Movie(MovieId));
        Session["Cart"] = temp;
      }
      return View("Index", new NetQuax.Models.HomePageModel());
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