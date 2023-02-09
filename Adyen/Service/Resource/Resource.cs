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
using System.Threading.Tasks;
using Adyen.Model;

namespace Adyen.Service.Resource
{
    public class Resource
    {
        private AbstractService _abstractService;
        protected string Endpoint;

        public Resource(AbstractService abstractService, string endpoint)
        {
            _abstractService = abstractService;
            Endpoint = endpoint;
        }
        
        public string Request(string json, RequestOptions requestOptions = null)
        {
            var clientInterface = this._abstractService.Client.HttpClient;
            return clientInterface.Request(this.Endpoint, json, requestOptions, null);
        }

        public async Task<string> RequestAsync(string json, RequestOptions requestOptions = null)
        {
            var clientInterface = this._abstractService.Client.HttpClient;
            return await clientInterface.RequestAsync(this.Endpoint, json, requestOptions, null);
        }
    }
}