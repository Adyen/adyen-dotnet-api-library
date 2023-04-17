using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Adyen.Exceptions;
using Environment = Adyen.Model.Environment;

namespace Adyen.Service
{
    public class AbstractService
    {
        public Client Client { get; set; }

        protected AbstractService(Client client)
        {
            Client = client;
        }

        /// <summary>
        /// Build the query string
        /// </summary>
        /// <param name="queryParams">Key, value pairs</param>
        /// <returns>URL encoded query string</returns>
        private protected static string ToQueryString(IDictionary<string, string> queryParams)
        {
            if (queryParams == null || queryParams.Count == 0)
            {
                return string.Empty;
            }

            var queryString = string.Join("&",
                queryParams.Select(kvp => $"{kvp.Key}={HttpUtility.UrlEncode(kvp.Value)}"));

            if (!string.IsNullOrEmpty(queryString))
            {
                return "?" + queryString;
            }

            return string.Empty;
        }
        
        /// <summary>
        /// The base URL creation for Live environment
        /// </summary>
        /// <param name="url">String</param>
        /// <returns>baseURL</returns>
        private protected string CreateBaseUrl(string url)
        {
            var config = Client.Config;
            // Change base url for Live environment
            if (config.Environment != Environment.Live) return url;
            if (url.Contains("pal-"))
            {
                // TODO these errors are not easy catchable for some reason, should be fixed first
                if (config.LiveEndpointUrlPrefix == default) {throw new InvalidOperationException(ExceptionMessages.MissingLiveEndpointUrlPrefix); }
                
                url = url.Replace("https://pal-test.adyen.com/pal/servlet/",
                    "https://" + config.LiveEndpointUrlPrefix + "-pal-live.adyenpayments.com/pal/servlet/");
            }
            else if (url.Contains("checkout-"))
            {
                if (config.LiveEndpointUrlPrefix == default) {throw new InvalidOperationException(ExceptionMessages.MissingLiveEndpointUrlPrefix); }
                
                url = url.Replace("https://checkout-test.adyen.com/",
                    "https://" + config.LiveEndpointUrlPrefix + "-checkout-live.adyenpayments.com/checkout/");
            }
                
            // If no prefix is required just replace "test" -> "live"
            url = url.Replace("-test", "-live");
            return url;
        }
    }
}