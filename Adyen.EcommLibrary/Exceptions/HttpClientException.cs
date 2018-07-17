using System;
using System.Collections.Generic;

namespace Adyen.EcommLibrary.HttpClientHandler
{
    public class HttpClientException : Exception
    {
        public int Code { get; private set; }
        public Dictionary<string, List<string>> ResponseHeaders { get; private set; }
        public string ResponseBody { get; private set; }


        public HttpClientException()
        {
        }

        public HttpClientException(string message) : base(message)
        {
        }

        public HttpClientException(int code, string message) : base(message)
        {
            this.Code = code;
        }


        public HttpClientException( int code, string message, Dictionary<string, List<string>> responseHeaders, string responseBody) : base(message)
        {
            this.Code = code;
            this.ResponseHeaders = responseHeaders;
            this.ResponseBody = responseBody;
        }
    }
}
