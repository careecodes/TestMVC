using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

using TestMVC.Models;
using TestMVC.Repositories;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            @ViewBag.Title = "Hello World!";

            var users = UserRepository.GetUsers();

            return View("Index", users);
        }
    }
}