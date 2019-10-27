using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace lojaDePecasDeCarro
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Pecas",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Pecas",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );
            routes.MapRoute(
                name: "FindById",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Pecas",
                    action = "FindById",
                    id = UrlParameter.Optional
                }
            );
        }

      
    }
}
