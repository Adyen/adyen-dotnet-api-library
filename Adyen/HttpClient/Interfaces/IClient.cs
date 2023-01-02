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
        /// Sends a synchronous request to the specified <paramref name="endpoint"/>.
        /// </summary>
        /// <param name="endpoint">URL of the endpoint.</param>
        /// <param name="json">Json request parameters for Post/Patch.</param>
        /// <param name="isApiKeyRequired"></param>
        /// <param name="requestOptions">Optional parameter used to specify the options for the request.</param>
        /// <param name="httpMethod">Request Method.</param>
        /// <returns>A string response in json format.</returns>
        string Request(string endpoint, string json, bool isApiKeyRequired, RequestOptions requestOptions = null, HttpMethod httpMethod = null);
        
        /// <summary>
        /// Sends an asynchronous request to the specified <paramref name="endpoint"/>.
        /// </summary>
        /// <param name="endpoint">URL of the endpoint.</param>
        /// <param name="json">Json request parameters for Post/Patch.</param>
        /// <param name="isApiKeyRequired"></param>
        /// <param name="requestOptions">Optional parameter used to specify the options for the request.</param>
        /// <param name="httpMethod">Request Method.</param>
        /// <returns>A <see cref="Task"/> with string response in json format.</returns>
        Task<string> RequestAsync(string endpoint, string json, bool isApiKeyRequired, RequestOptions requestOptions = null, HttpMethod httpMethod = null);
        string Post(string endpoint, Dictionary<string, string> postParameters);
    }
}