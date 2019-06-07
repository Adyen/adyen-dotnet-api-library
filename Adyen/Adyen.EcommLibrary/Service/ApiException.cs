using Adyen.EcommLibrary.Model;
using System;

namespace Adyen.EcommLibrary.Service
{
    public class ApiException:Exception
    {
        public int StatusCode { get; set; }

        public ApiError ApiError{ get; set; }

        public ApiException(int statusCode,string message)
            :base(message)
        {
            this.StatusCode = statusCode;
        }
    }
}
