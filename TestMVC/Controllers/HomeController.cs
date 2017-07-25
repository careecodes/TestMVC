using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

// Declaring my model in the controller, tying the controller (this) to the model
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
			// Pretending we got this from the Service Layer (db, etc)
			var foobar = new FoobarView();
            foobar.FirstName = "Caree";
            foobar.LastName = "Youngman";

            // Returning the view, passing the model in, trying the controller (this) to the view
            return View(foobar);
        }
    }
}
