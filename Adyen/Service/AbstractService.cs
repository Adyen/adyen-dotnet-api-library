using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}