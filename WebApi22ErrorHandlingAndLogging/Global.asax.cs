using System.Web.Http;



namespace WebApi22ErrorHandlingAndLogging
{
    
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            WebApiConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}