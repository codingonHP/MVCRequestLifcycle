using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MVCRequestLifeCycle.Handlers;

namespace MVCRequestLifeCycle
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           routes.Add(new Route("home/about", new SimpleRouteHandler()));

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }

        public class SimpleRouteHandler : IRouteHandler
        {
            public IHttpHandler GetHttpHandler(RequestContext requestContext)
            {
                return new SimpleHandler(); 
            }
        }
    }
}
