using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Lab1.Handlers;

namespace Lab1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.Add(new Route("service/{*path}.pyb", new ServiceRouteHandler()));
            routes.IgnoreRoute("service.pyb");
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
        }
        
        // class ServiceRouteHandler : IRouteHandler
        // {
        //     public IHttpHandler GetHttpHandler(RequestContext requestContext)
        //     {
        //         return new ServiceHandler();
        //     }
        // }
    }
}