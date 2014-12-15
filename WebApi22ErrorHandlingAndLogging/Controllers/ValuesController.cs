using System.Web.Http;
using Elmah;

namespace WebApi22ErrorHandlingAndLogging.Controllers
{
    public class ValuesController : ApiController
    {
        // un comment this line to test constructor errors
        //public ValuesController()
        //{
        //    throw new ApplicationException("app exception inside ValuesController constructor");
        //}
        
        public string Get()
        {
            throw new ApplicationException("app exception inside Get action");
            return string.Empty;
        }

        
    }
}