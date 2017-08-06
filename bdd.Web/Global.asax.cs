using System.Web.Mvc;
using System.Web.Routing;

namespace bdd.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Dependency Container setup
            IocContainer.Setup();
        }
    }
}