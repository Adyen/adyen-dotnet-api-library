/*
* Adyen Balance Control API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.BalanceControl;
using Newtonsoft.Json;

namespace Adyen.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BalanceControlService : AbstractService
    {
        private readonly string _baseUrl;
        
        public BalanceControlService(Client client) : base(client)
        {
            _baseUrl = client.Config.Endpoint + "/pal/servlet/BalanceControl/" + ClientConfig.BalanceControlVersion;
        }
    
        /// <summary>
        /// Start a balance transfer
        /// </summary>
        /// <param name="balanceTransferRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>BalanceTransferResponse</returns>
        public BalanceTransferResponse BalanceTransfer(BalanceTransferRequest balanceTransferRequest, RequestOptions requestOptions = default)
        {
            return BalanceTransferAsync(balanceTransferRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Start a balance transfer
        /// </summary>
        /// <param name="balanceTransferRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of BalanceTransferResponse</returns>
        public async Task<BalanceTransferResponse> BalanceTransferAsync(BalanceTransferRequest balanceTransferRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/balanceTransfer";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<BalanceTransferResponse>(balanceTransferRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

    }
}
