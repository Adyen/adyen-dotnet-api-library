using System;
using System.Net;

namespace Adyen.EcommLibrary.HttpClient
{
    public class HttpClientException : Exception
    {
        public int Code { get; private set; }
        public string JsonResponse { get; private set; }
        public WebHeaderCollection WebHeaderCollection { get; private set; }
        public string ResponseBody { get; private set; }

        public Exception Exception { get; private set; }

        public HttpClientException(int code, string message, WebHeaderCollection webHeaderCollection,
            string responseBody) : base(message)
        {
            Code = code;
            WebHeaderCollection = webHeaderCollection;
            ResponseBody = responseBody;
        }

        public HttpClientException(int code, string message, WebHeaderCollection webHeaderCollection,
            string responseBody, Exception exception) : base(message)
        {
            Code = code;
            WebHeaderCollection = webHeaderCollection;
            ResponseBody = responseBody;
            Exception = exception;
        }
    }
}