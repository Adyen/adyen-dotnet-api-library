using System;
using System.Net;

namespace Adyen.HttpClient
{
    public class HttpClientException : Exception
    {
        public int Code { get; }
        public string JsonResponse { get; private set; }
        public WebHeaderCollection WebHeaderCollection { get; }
        public string ResponseBody { get; }

        public Exception Exception { get; }
        public HttpClientException(int code, string message, WebHeaderCollection webHeaderCollection, string responseBody) : base(message)
        {
            Code = code;
            WebHeaderCollection = webHeaderCollection;
            ResponseBody = responseBody;
        }
        
        public HttpClientException(int code, string message, string responseBody) : base(message)
        {
            Code = code;
            ResponseBody = responseBody;
        }
        public HttpClientException(int code, string message, WebHeaderCollection webHeaderCollection, string responseBody, Exception exception) : base(message)
        {
            Code = code;
            WebHeaderCollection = webHeaderCollection;
            ResponseBody = responseBody;
            Exception = exception;
        }
    }
}
