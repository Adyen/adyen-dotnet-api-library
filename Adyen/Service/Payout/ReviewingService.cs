/*
* Adyen Payout API
*
*
* The version of the OpenAPI document: 68
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
using Adyen.Model.Payout;
using Newtonsoft.Json;

namespace Adyen.Service.Payout
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReviewingService : AbstractService
    {
        private readonly string _baseUrl;
        
        public ReviewingService(Client client) : base(client)
        {
            _baseUrl = client.Config.Endpoint + "/pal/servlet/Payout/" + ClientConfig.PayoutApiVersion;
        }
    
        /// <summary>
        /// Confirm a payout
        /// </summary>
        /// <param name="modifyRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ModifyResponse</returns>
        public ModifyResponse ConfirmPayout(ModifyRequest modifyRequest, RequestOptions requestOptions = default)
        {
            return ConfirmPayoutAsync(modifyRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Confirm a payout
        /// </summary>
        /// <param name="modifyRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ModifyResponse</returns>
        public async Task<ModifyResponse> ConfirmPayoutAsync(ModifyRequest modifyRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/confirmThirdParty";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ModifyResponse>(modifyRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

        /// <summary>
        /// Cancel a payout
        /// </summary>
        /// <param name="modifyRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ModifyResponse</returns>
        public ModifyResponse CancelPayout(ModifyRequest modifyRequest, RequestOptions requestOptions = default)
        {
            return CancelPayoutAsync(modifyRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cancel a payout
        /// </summary>
        /// <param name="modifyRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ModifyResponse</returns>
        public async Task<ModifyResponse> CancelPayoutAsync(ModifyRequest modifyRequest, RequestOptions requestOptions = default)
        {
            var endpoint = _baseUrl + "/declineThirdParty";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ModifyResponse>(modifyRequest.ToJson(), requestOptions, new HttpMethod("POST"));
        }

    }
}
