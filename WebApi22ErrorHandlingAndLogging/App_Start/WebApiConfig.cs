using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using WebApi22ErrorHandlingAndLogging.ExceptionHandling;

namespace WebApi22ErrorHandlingAndLogging
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Services.Add(typeof(IExceptionLogger), new ElmahExceptionLogger());
            config.Services.Replace(typeof(IExceptionHandler), new GenericExceptionHandler());

        }
    }
}
