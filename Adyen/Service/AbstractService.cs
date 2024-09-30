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

        private const string PaymentPrefix = "pal-";
        private const string CheckoutPrefix = "checkout-";

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
        /// The base URL creation for the environment
        /// </summary>
        /// <param name="url">String</param>
        /// <returns>baseURL</returns>
        private protected string CreateBaseUrl(string url)
        {
            var config = Client.Config;
            return config.Environment == Environment.Live
                ? ConstructLiveUrl(config,
                    url)
                : ConstructTestUrl(config,
                    url);
        }

        /// <summary>
        /// Allow users to override the baseUrl in a test environment
        /// </summary>
        /// <param name="config">Config</param>
        /// <param name="url">String</param>
        /// <returns>baseUrl</returns>
        private static string ConstructTestUrl(Config config, string url)
        {
            if (config.BaseUrlConfig == null) return url.Replace("-live", "-test");
                
            var baseUrl = config.BaseUrlConfig.BaseUrl;
            if (url.Contains(PaymentPrefix) 
                && !string.IsNullOrEmpty(config.BaseUrlConfig.PaymentUrl))
            {
                baseUrl = config.BaseUrlConfig.PaymentUrl;
            } else if (url.Contains(CheckoutPrefix) 
                       && !string.IsNullOrEmpty(config.BaseUrlConfig.CheckoutUrl))
            {
                baseUrl = config.BaseUrlConfig.CheckoutUrl;
            }

            var urlPath = new Uri(url).AbsolutePath;
            var returnUrl = new Uri(baseUrl + urlPath).ToString();
            
            return returnUrl;
        }

        /// <summary>
        /// Construct live baseUrl 
        /// </summary>
        /// <param name="config">Config</param>
        /// <param name="url">String</param>
        /// <returns>baseUrl</returns>
        /// <exception cref="InvalidOperationException"></exception>
        private static string ConstructLiveUrl(Config config, string url)
        {
            // Change base url for Live environment
            if (url.Contains(PaymentPrefix))
            {
                if (config.LiveEndpointUrlPrefix == default)
                {
                    throw new InvalidOperationException(ExceptionMessages.MissingLiveEndpointUrlPrefix);
                }
                
                url = url.Replace("https://pal-test.adyen.com/pal/servlet/",
                    "https://" + config.LiveEndpointUrlPrefix + "-pal-live.adyenpayments.com/pal/servlet/");
            }
            else if (url.Contains(CheckoutPrefix))
            {
                if (config.LiveEndpointUrlPrefix == default)
                {
                    throw new InvalidOperationException(ExceptionMessages.MissingLiveEndpointUrlPrefix);
                }

                if (url.Contains("possdk"))
                {
                    url = url.Replace("https://checkout-test.adyen.com/",
                        "https://" + config.LiveEndpointUrlPrefix + "-checkout-live.adyenpayments.com/");   
                }
                else
                {
                    url = url.Replace("https://checkout-test.adyen.com/",
                        "https://" + config.LiveEndpointUrlPrefix + "-checkout-live.adyenpayments.com/checkout/");
                }
            }
                
                
            // If no prefix is required just replace "test" -> "live"
            url = url.Replace("-test", "-live");
            return url;
        }
    }
}