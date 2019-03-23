using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApplication.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      TestApplication.Models.ExampleModel model = new Models.ExampleModel();
      return View(model);
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

    public JsonResult ControllerMethod(FormCollection form)
    {
      string name = string.Empty;
      if(form != null)
      {
        if (form.AllKeys.Contains("Test"))
        {
          name = form["test"];
        }
      }
      return Json(new
      {
        Name = name
      });
    }
  }
}