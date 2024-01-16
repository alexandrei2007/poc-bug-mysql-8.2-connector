using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PocMySQL
{
    public class MvcApplication : HttpApplication
    {

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "PocMySQL.Controllers" }
            );
        }

        protected void Application_Start()
        {
            //Registering some regular mvc stuff
            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);
        }
    }
}

