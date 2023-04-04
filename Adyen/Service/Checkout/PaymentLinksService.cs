/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
* Contact: developer-experience@adyen.com
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
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Checkout;

namespace Adyen.Service.Checkout
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentLinksService : AbstractService, IPaymentLinksService
    {
        private readonly string _baseUrl;
        
        public PaymentLinksService(Client client) : base(client)
        {
            _baseUrl = client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion;
        }
    
        public PaymentLinkResponse GetPaymentLink(string linkId, RequestOptions requestOptions = default)
        {
            return GetPaymentLinkAsync(linkId, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<PaymentLinkResponse> GetPaymentLinkAsync(string linkId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/paymentLinks/{linkId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentLinkResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }

        public PaymentLinkResponse UpdatePaymentLink(string linkId, UpdatePaymentLinkRequest updatePaymentLinkRequest, RequestOptions requestOptions = default)
        {
            return UpdatePaymentLinkAsync(linkId, updatePaymentLinkRequest, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<PaymentLinkResponse> UpdatePaymentLinkAsync(string linkId, UpdatePaymentLinkRequest updatePaymentLinkRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/paymentLinks/{linkId}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentLinkResponse>(updatePaymentLinkRequest.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken);
        }

        public PaymentLinkResponse PaymentLinks(CreatePaymentLinkRequest createPaymentLinkRequest, RequestOptions requestOptions = default)
        {
            return PaymentLinksAsync(createPaymentLinkRequest, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<PaymentLinkResponse> PaymentLinksAsync(CreatePaymentLinkRequest createPaymentLinkRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/paymentLinks";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentLinkResponse>(createPaymentLinkRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

    }
    
    /// <summary>
    /// Service Interface
    /// </summary>
    public interface IPaymentLinksService
    {
        /// <summary>
        /// Get a payment link
        /// </summary>
        /// <param name="linkId">Unique identifier of the payment link.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentLinkResponse</returns>
        PaymentLinkResponse GetPaymentLink(string linkId, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a payment link
        /// </summary>
        /// <param name="linkId">Unique identifier of the payment link.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of PaymentLinkResponse</returns>
        Task<PaymentLinkResponse> GetPaymentLinkAsync(string linkId, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update the status of a payment link
        /// </summary>
        /// <param name="linkId">Unique identifier of the payment link.</param>
        /// <param name="updatePaymentLinkRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentLinkResponse</returns>
        PaymentLinkResponse UpdatePaymentLink(string linkId, UpdatePaymentLinkRequest updatePaymentLinkRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update the status of a payment link
        /// </summary>
        /// <param name="linkId">Unique identifier of the payment link.</param>
        /// <param name="updatePaymentLinkRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of PaymentLinkResponse</returns>
        Task<PaymentLinkResponse> UpdatePaymentLinkAsync(string linkId, UpdatePaymentLinkRequest updatePaymentLinkRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create a payment link
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createPaymentLinkRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentLinkResponse</returns>
        PaymentLinkResponse PaymentLinks(CreatePaymentLinkRequest createPaymentLinkRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a payment link
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createPaymentLinkRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of PaymentLinkResponse</returns>
        Task<PaymentLinkResponse> PaymentLinksAsync(CreatePaymentLinkRequest createPaymentLinkRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
}