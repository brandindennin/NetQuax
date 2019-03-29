using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetQuax.Entities;

namespace NetQuax.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      //NetQuax.Entities.User user = new NetQuax.Entities.User(1);
     
      return View();
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


    /// <summary cref="User" >">
    /// Adds A new user based upon inputs from add user form
    /// </summary> 
    public ActionResult AddUser(FormCollection form)
    {
      string detectedUserName = string.Empty;
      string detectedPassword = string.Empty;
      string detectedPasswordConfirmation = string.Empty;
      string errorMessage = string.Empty;
      bool errorFlag = false;
      if(form != null)
      {
        if (form.AllKeys.Contains("UserName"))
        {
          detectedUserName = form["UserName"];
        }
        if(form.AllKeys.Contains("Password"))
        {
          detectedPassword = form["Password"];
        }
        if(form.AllKeys.Contains("PasswordConfirmation"))
        {
          detectedPasswordConfirmation = form["PasswordConfirmation"];
        }
      }

      if(detectedUserName == string.Empty)
      {
        errorFlag = true;
        errorMessage = "Username is required";        
      }

      if(detectedPassword == string.Empty)
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
      if(!errorFlag)
      {
        //TODO: return home view 
      }
      else
      {
        //TODO: Return Error View
      }

      return null;
    }
  }
}