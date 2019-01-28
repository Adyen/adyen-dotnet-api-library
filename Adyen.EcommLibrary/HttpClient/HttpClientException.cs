using System;
using System.Collections.Generic;
using System.Net;

namespace Adyen.EcommLibrary.HttpClient
{
    public class HttpClientException : Exception
    {
        public int Code { get; private set; }
        public string JsonResponse { get; private set; }
        public WebHeaderCollection WebHeaderCollection { get; private set; }
        public string ResponseBody { get; private set; }

        public HttpClientException(int code, string message, WebHeaderCollection webHeaderCollection, string responseBody) : base(message)
        {
            this.Code = code;
            this.WebHeaderCollection = webHeaderCollection;
            this.ResponseBody = responseBody;
        }
    }
}
