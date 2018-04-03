using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace A2Rnd
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

                                   // when the user types in a link handled by client side routing to the address bar 
            // or refreshes the page, that triggers the server routing. The server should pass 
            // that onto the client, so Angular can handle the route
            routes.MapRoute(
                name: "spa-fallback",
                url: "{*url}",
                defaults: new { controller = "Public", action = "Index" }
            );


        }
    }
}
