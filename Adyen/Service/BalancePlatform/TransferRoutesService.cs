/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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
using Adyen.Model.BalancePlatform;

namespace Adyen.Service.BalancePlatform
{
    /// <summary>
    /// TransferRoutesService Interface
    /// </summary>
    public interface ITransferRoutesService
    {
        /// <summary>
        /// Calculate transfer routes
        /// </summary>
        /// <param name="transferRouteRequest"><see cref="TransferRouteRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="TransferRouteResponse"/>.</returns>
        Model.BalancePlatform.TransferRouteResponse CalculateTransferRoutes(TransferRouteRequest transferRouteRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Calculate transfer routes
        /// </summary>
        /// <param name="transferRouteRequest"><see cref="TransferRouteRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="TransferRouteResponse"/>.</returns>
        Task<Model.BalancePlatform.TransferRouteResponse> CalculateTransferRoutesAsync(TransferRouteRequest transferRouteRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the TransferRoutesService API endpoints
    /// </summary>
    public class TransferRoutesService : AbstractService, ITransferRoutesService
    {
        private readonly string _baseUrl;
        
        public TransferRoutesService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://balanceplatform-api-test.adyen.com/bcl/v2");
        }
        
        public Model.BalancePlatform.TransferRouteResponse CalculateTransferRoutes(TransferRouteRequest transferRouteRequest = default, RequestOptions requestOptions = default)
        {
            return CalculateTransferRoutesAsync(transferRouteRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.BalancePlatform.TransferRouteResponse> CalculateTransferRoutesAsync(TransferRouteRequest transferRouteRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/transferRoutes/calculate";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.BalancePlatform.TransferRouteResponse>(transferRouteRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}