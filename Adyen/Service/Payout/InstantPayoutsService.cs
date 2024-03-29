/*
* Adyen Payout API
*
*
* The version of the OpenAPI document: 68
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Model.Payout;

namespace Adyen.Service.Payout
{
    /// <summary>
    /// InstantPayoutsService Interface
    /// </summary>
    public interface IInstantPayoutsService
    {
        /// <summary>
        /// Make an instant card payout
        /// </summary>
        /// <param name="payoutRequest"><see cref="PayoutRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PayoutResponse"/>.</returns>
        Model.Payout.PayoutResponse Payout(PayoutRequest payoutRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Make an instant card payout
        /// </summary>
        /// <param name="payoutRequest"><see cref="PayoutRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PayoutResponse"/>.</returns>
        Task<Model.Payout.PayoutResponse> PayoutAsync(PayoutRequest payoutRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the InstantPayoutsService API endpoints
    /// </summary>
    public class InstantPayoutsService : AbstractService, IInstantPayoutsService
    {
        private readonly string _baseUrl;
        
        public InstantPayoutsService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://pal-test.adyen.com/pal/servlet/Payout/v68");
        }
        
        public Model.Payout.PayoutResponse Payout(PayoutRequest payoutRequest = default, RequestOptions requestOptions = default)
        {
            return PayoutAsync(payoutRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Payout.PayoutResponse> PayoutAsync(PayoutRequest payoutRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/payout";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Payout.PayoutResponse>(payoutRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}