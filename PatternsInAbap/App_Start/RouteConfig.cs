using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PatternsInAbap
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
          
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "DefaultAdmin",
                "{controller}/{action}/{ptrnName}",
                new { ptrnName = (String)null },
                new { Controller = "Admin" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{ptrnType}",
                defaults: new { controller = "Home", action = "List", ptrnType = (String)null }
            );

            
        }
    }
}
