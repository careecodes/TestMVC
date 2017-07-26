using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

// Declaring my model in the controller, tying the controller (this) to the model
using TestMVC.Models;
using TestMVC.Repositories;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Use the repository to get the users from the Unicorn Service Layer (db, etc)
            var users = UserRepository.GetUsers();

			// Returning the view, passing the model in, tying the controller (this) to the view
			return View("Index", users.First());
          //return View(foobar);
        }
    }
}


/*
TODO:
1) Remove cole's useless class additions
2) Rename FoobarView to UserModel everywhere
3) Add 3 new users to the list of users in the GetUsers method directly
4) Add some design/styling to the site to make it so we can show more than one user

Next week: Iterating the users in the view so we can display more than one on the home page
*/
