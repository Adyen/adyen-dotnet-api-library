/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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
using Adyen.Model.BalancePlatform;

namespace Adyen.Service.BalancePlatform
{
    /// <summary>
    /// PaymentInstrumentsService Interface
    /// </summary>
    public interface IPaymentInstrumentsService
    {
        /// <summary>
        /// Get a payment instrument
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the payment instrument.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentInstrument"/>.</returns>
        PaymentInstrument GetPaymentInstrument(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a payment instrument
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the payment instrument.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentInstrument"/>.</returns>
        Task<PaymentInstrument> GetPaymentInstrumentAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get the reveal information of a payment instrument
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the payment instrument.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentInstrumentRevealInfo"/>.</returns>
        PaymentInstrumentRevealInfo GetRevealInformationOfPaymentInstrument(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get the reveal information of a payment instrument
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the payment instrument.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentInstrumentRevealInfo"/>.</returns>
        Task<PaymentInstrumentRevealInfo> GetRevealInformationOfPaymentInstrumentAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get all transaction rules for a payment instrument
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the payment instrument.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="TransactionRulesResponse"/>.</returns>
        TransactionRulesResponse GetAllTransactionRulesForPaymentInstrument(string id, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get all transaction rules for a payment instrument
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the payment instrument.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="TransactionRulesResponse"/>.</returns>
        Task<TransactionRulesResponse> GetAllTransactionRulesForPaymentInstrumentAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update a payment instrument
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the payment instrument.</param>
        /// <param name="paymentInstrumentUpdateRequest"><see cref="PaymentInstrumentUpdateRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="UpdatePaymentInstrument"/>.</returns>
        UpdatePaymentInstrument UpdatePaymentInstrument(string id, PaymentInstrumentUpdateRequest paymentInstrumentUpdateRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update a payment instrument
        /// </summary>
        /// <param name="id"><see cref="string"/> - The unique identifier of the payment instrument.</param>
        /// <param name="paymentInstrumentUpdateRequest"><see cref="PaymentInstrumentUpdateRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="UpdatePaymentInstrument"/>.</returns>
        Task<UpdatePaymentInstrument> UpdatePaymentInstrumentAsync(string id, PaymentInstrumentUpdateRequest paymentInstrumentUpdateRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create a payment instrument
        /// </summary>
        /// <param name="paymentInstrumentInfo"><see cref="PaymentInstrumentInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentInstrument"/>.</returns>
        PaymentInstrument CreatePaymentInstrument(PaymentInstrumentInfo paymentInstrumentInfo, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a payment instrument
        /// </summary>
        /// <param name="paymentInstrumentInfo"><see cref="PaymentInstrumentInfo"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentInstrument"/>.</returns>
        Task<PaymentInstrument> CreatePaymentInstrumentAsync(PaymentInstrumentInfo paymentInstrumentInfo, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the PaymentInstrumentsService API endpoints
    /// </summary>
    public class PaymentInstrumentsService : AbstractService, IPaymentInstrumentsService
    {
        private readonly string _baseUrl;
        
        public PaymentInstrumentsService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://balanceplatform-api-test.adyen.com/bcl/v2");
        }
        
        public PaymentInstrument GetPaymentInstrument(string id, RequestOptions requestOptions = default)
        {
            return GetPaymentInstrumentAsync(id, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<PaymentInstrument> GetPaymentInstrumentAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/paymentInstruments/{id}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentInstrument>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }
        
        public PaymentInstrumentRevealInfo GetRevealInformationOfPaymentInstrument(string id, RequestOptions requestOptions = default)
        {
            return GetRevealInformationOfPaymentInstrumentAsync(id, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<PaymentInstrumentRevealInfo> GetRevealInformationOfPaymentInstrumentAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/paymentInstruments/{id}/reveal";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentInstrumentRevealInfo>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }
        
        public TransactionRulesResponse GetAllTransactionRulesForPaymentInstrument(string id, RequestOptions requestOptions = default)
        {
            return GetAllTransactionRulesForPaymentInstrumentAsync(id, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<TransactionRulesResponse> GetAllTransactionRulesForPaymentInstrumentAsync(string id, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/paymentInstruments/{id}/transactionRules";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<TransactionRulesResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken);
        }
        
        public UpdatePaymentInstrument UpdatePaymentInstrument(string id, PaymentInstrumentUpdateRequest paymentInstrumentUpdateRequest, RequestOptions requestOptions = default)
        {
            return UpdatePaymentInstrumentAsync(id, paymentInstrumentUpdateRequest, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<UpdatePaymentInstrument> UpdatePaymentInstrumentAsync(string id, PaymentInstrumentUpdateRequest paymentInstrumentUpdateRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/paymentInstruments/{id}";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<UpdatePaymentInstrument>(paymentInstrumentUpdateRequest.ToJson(), requestOptions, new HttpMethod("PATCH"), cancellationToken);
        }
        
        public PaymentInstrument CreatePaymentInstrument(PaymentInstrumentInfo paymentInstrumentInfo, RequestOptions requestOptions = default)
        {
            return CreatePaymentInstrumentAsync(paymentInstrumentInfo, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<PaymentInstrument> CreatePaymentInstrumentAsync(PaymentInstrumentInfo paymentInstrumentInfo, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/paymentInstruments";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentInstrument>(paymentInstrumentInfo.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }
    }
}