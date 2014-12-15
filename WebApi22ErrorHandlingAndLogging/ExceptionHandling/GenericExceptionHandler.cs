using System.Text;
using System.Web.Http.ExceptionHandling;

namespace WebApi22ErrorHandlingAndLogging.ExceptionHandling
{
    public class GenericExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            context.Result = new InternalServerErrorResult(
                "Aggghhh! An unhandled exception occurred; check the log for more information :(",
                Encoding.UTF8, context.Request, "MYAPP0001");
        }


    }
}

