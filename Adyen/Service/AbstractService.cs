#region License

// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */

#endregion

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
            this.Client = client;
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