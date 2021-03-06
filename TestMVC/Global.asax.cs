﻿using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using TestMVC.App_Start;

namespace TestMVC
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
        }
    }
}
