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
using System.Threading.Tasks;

namespace Adyen.Service
{
    public class ServiceRestResource
    {
        private readonly AbstractService _abstractService;
        protected string endpoint;
        private IRestClient _clientInterface;
        public ServiceRestResource(AbstractService abstractService, string endpoint)
        {
            _abstractService = abstractService;
            this.endpoint = endpoint;
            _clientInterface = _abstractService.Client.HttpRestClient;
        }
        public async Task<string> GetAsync(string json)
        {
            return await _clientInterface.GetAsync(endpoint,json, _abstractService.Client.Config);
        }
        public async Task<string> PostAsync(string json)
        {
            return await _clientInterface.PostAsync(endpoint, json, _abstractService.Client.Config);
        }
        public async Task<string> PatchAsync(string json)
        {
            return await _clientInterface.PatchAsync(endpoint, json, _abstractService.Client.Config);
        }
        public async Task<string> DeleteAsync(string json)
        {
            return await _clientInterface.DeleteAsync(endpoint, json, _abstractService.Client.Config);
        }

        public string Get(string json, string addition = null)
        {
            var endpointWithAddition = CreateUrl(endpoint, addition);
            return _clientInterface.Get(endpoint, json, _abstractService.Client.Config);
        }

        public string Post(string json)
        {
            return _clientInterface.Post(endpoint, json, _abstractService.Client.Config);
        }
        public string Patch(string json)
        {
            return _clientInterface.Patch(endpoint, json, _abstractService.Client.Config);
        }
        public string Delete(string json)
        {
            return _clientInterface.Delete(endpoint, json, _abstractService.Client.Config);
        }


        private object CreateUrl(string endpoint, string addition)
        {
            return endpoint + "/" + addition;
        }
    }
}
