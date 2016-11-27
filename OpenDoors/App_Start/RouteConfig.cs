using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OpenDoors
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Ru",
                url: "{language}/{controller}/{action}/{id}",
                defaults: new { language = "ru", controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "OpenDoors.Areas.ru.Controllers" }
            ).DataTokens.Add("area","ru");
        }
    }
}
