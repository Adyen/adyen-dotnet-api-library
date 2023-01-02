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
//  * Copyright (c) 2022 Adyen N.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
#endregion

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Model;

namespace Adyen.HttpClient.Interfaces
{
    public interface IClient : IDisposable
    {
        /// <summary>
        /// Request Method synchronous.
        /// </summary>
        /// <param name="endpoint">Url of the endpoint.</param>
        /// <param name="json">Json request parameters for Post/Patch.</param>
        /// <param name="isApiKeyRequired"></param>
        /// <param name="requestOptions">Optional parameter used to specify the options for the request.</param>
        /// <param name="httpMethod">Request Method.</param>
        /// <returns>string</returns>
        string Request(string endpoint, string json, bool isApiKeyRequired, RequestOptions requestOptions = null, HttpMethod httpMethod = null);
        
        /// <summary>
        /// Request Method asynchronous.
        /// </summary>
        /// <param name="endpoint">Url of the endpoint.</param>
        /// <param name="json">Json request parameters for Post/Patch.</param>
        /// <param name="isApiKeyRequired"></param>
        /// <param name="requestOptions">Optional parameter used to specify the options for the request.</param>
        /// <param name="httpMethod">Request Method.</param>
        /// <returns>string</returns>
        Task<string> RequestAsync(string endpoint, string json, bool isApiKeyRequired, RequestOptions requestOptions = null, HttpMethod httpMethod = null);
        string Post(string endpoint, Dictionary<string, string> postParameters);
    }
}