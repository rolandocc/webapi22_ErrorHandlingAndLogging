using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi22ErrorHandlingAndLogging.ExceptionHandling
{
    public class InternalServerErrorResult : IHttpActionResult
    {
        private readonly string _myAppErrorCode ;
        public InternalServerErrorResult(string content, Encoding encoding, HttpRequestMessage request, string myAppErrorcode)
        {
            if (content == null)
            {
                throw new ArgumentNullException("content");
            }

            if (encoding == null)
            {
                throw new ArgumentNullException("encoding");
            }

            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            _myAppErrorCode = myAppErrorcode;

            Content = content;
            Encoding = encoding;
            Request = request;
        }

        public string Content { get; private set; }

        public Encoding Encoding { get; private set; }

        public HttpRequestMessage Request { get; private set; }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(Execute());
        }

        private HttpResponseMessage Execute()
        {
            var err = new HttpError(Content) { { "myAppErrorcode", _myAppErrorCode } };
            return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, err);
        }
    }
}