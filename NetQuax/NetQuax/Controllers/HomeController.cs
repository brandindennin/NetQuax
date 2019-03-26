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
      NetQuax.Entities.User user = new NetQuax.Entities.User(1);
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

    public ActionResult AddUser(FormCollection form)
    {
      return null;
    }
  }
}