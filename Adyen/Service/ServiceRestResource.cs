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
        protected string Endpoint;
        private IRestClient _clientInterface;
        public ServiceRestResource(AbstractService abstractService, string endpoint)
        {
            _abstractService = abstractService;
            Endpoint = endpoint;
            _clientInterface = _abstractService.Client.HttpRestClient;
        }
        public async Task<string> GetAsync(string json)
        {
            return await _clientInterface.GetAsync(Endpoint,json, _abstractService.Client.Config);
        }
        public async Task<string> PostAsync(string json)
        {
            return await _clientInterface.PostAsync(Endpoint, json, _abstractService.Client.Config);
        }
        public async Task<string> PatchAsync(string json)
        {
            return await _clientInterface.PatchAsync(Endpoint, json, _abstractService.Client.Config);
        }
        public async Task<string> DeleteAsync(string json)
        {
            return await _clientInterface.DeleteAsync(Endpoint, json, _abstractService.Client.Config);
        }

        public string Get(string json)
        {
            return _clientInterface.Get(Endpoint, json, _abstractService.Client.Config);
        }
        public string Post(string json)
        {
            return _clientInterface.Post(Endpoint, json, _abstractService.Client.Config);
        }
        public string Patch(string json)
        {
            return _clientInterface.Patch(Endpoint, json, _abstractService.Client.Config);
        }
        public string Delete(string json)
        {
            return _clientInterface.Delete(Endpoint, json, _abstractService.Client.Config);
        }
    }
}
