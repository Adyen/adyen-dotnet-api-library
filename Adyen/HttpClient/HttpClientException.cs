﻿using System;
using System.Collections.Generic;
using System.Net;

namespace Adyen.HttpClient
{
    public class HttpClientException : Exception
    {
        public int Code { get; private set; }
        public string JsonResponse { get; private set; }
        public WebHeaderCollection WebHeaderCollection { get; private set; }
        public string ResponseBody { get; private set; }

        public Exception Exception { get; private set; }
        public HttpClientException(int code, string message, WebHeaderCollection webHeaderCollection, string responseBody) : base(message)
        {
            this.Code = code;
            this.WebHeaderCollection = webHeaderCollection;
            this.ResponseBody = responseBody;
        }
        public HttpClientException(int code, string message, WebHeaderCollection webHeaderCollection, string responseBody, Exception exception) : base(message)
        {
            this.Code = code;
            this.WebHeaderCollection = webHeaderCollection;
            this.ResponseBody = responseBody;
            this.Exception = exception;
        }
    }
}
