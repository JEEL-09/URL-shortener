using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace url_shortner_webapp
{
    public class Global : HttpApplication
    {
        void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("preview", "{ShortLink}", "~/redirect.aspx");
        }
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
           
            RegisterRoutes(RouteTable.Routes);
        }
    }
}