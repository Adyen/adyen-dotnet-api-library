#region License
/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion
using Adyen.HttpClient.Interfaces;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Adyen.Service
{
    public class ServiceRestResource
    {
        private readonly AbstractService _abstractService;
        protected string baseEndpoint;
        private IRestClient _clientInterface;
        public ServiceRestResource(AbstractService abstractService, string endpoint)
        {
            _abstractService = abstractService;
            this.baseEndpoint = endpoint;
            _clientInterface = _abstractService.Client.HttpRestClient;
        }
        public async Task<string> GetAsync(string json, string additionUri = null, Dictionary<string, string> options = null)
        {
            var uri = CreateUrl(baseEndpoint, additionUri);
            return await _clientInterface.GetAsync(uri, json, _abstractService.Client.Config);
        }
        public async Task<string> PostAsync(string json, string additionUri = null, Dictionary<string, string> options = null)
        {
            var uri = CreateUrl(baseEndpoint, additionUri);
            return await _clientInterface.PostAsync(uri, json, _abstractService.Client.Config);
        }
        public async Task<string> PatchAsync(string json, string additionUri = null, Dictionary<string, string> options = null)
        {
            var uri = CreateUrl(baseEndpoint, additionUri);
            return await _clientInterface.PatchAsync(uri, json, _abstractService.Client.Config);
        }
        public async Task<string> DeleteAsync(string json, string additionUri = null, Dictionary<string, string> options = null)
        {
            var uri = CreateUrl(baseEndpoint, additionUri);
            return await _clientInterface.DeleteAsync(uri, json, _abstractService.Client.Config);
        }

        public string Get(string json, string additionUri = null, Dictionary<string,string> options=null)
        {
            var uri = CreateUrl(baseEndpoint, additionUri);
            return _clientInterface.Get(uri, json, _abstractService.Client.Config);
        }

        public string Post(string json, string additionUri = null, Dictionary<string, string> options = null)
        {
            var uri = CreateUrl(baseEndpoint, additionUri);
            return _clientInterface.Post(uri, json, _abstractService.Client.Config);
        }
        public string Patch(string json, string additionUri = null, Dictionary<string, string> options = null)
        {
            var uri = CreateUrl(baseEndpoint, additionUri);
            return _clientInterface.Patch(uri, json, _abstractService.Client.Config);
        }
        public string Delete(string json, string additionUri = null, Dictionary<string,string> options=null)
        {
            var uri = CreateUrl(baseEndpoint, additionUri);
            return _clientInterface.Delete(uri, json, _abstractService.Client.Config);
        }

        private string CreateUrl(string endpoint, string addition)
        {
              return $"{endpoint}/{WebUtility.UrlEncode(addition)}";
        }
    }
}
