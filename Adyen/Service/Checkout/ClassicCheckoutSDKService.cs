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
    public class ClassicCheckoutSDKService : AbstractService, IClassicCheckoutSDKService
    {
        private readonly string _baseUrl;
        
        public ClassicCheckoutSDKService(Client client) : base(client)
        {
            _baseUrl = client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion;
        }
    
        [Obsolete]
        public PaymentSetupResponse PaymentSession(PaymentSetupRequest paymentSetupRequest, RequestOptions requestOptions = default)
        {
            return PaymentSessionAsync(paymentSetupRequest, requestOptions).GetAwaiter().GetResult();
        }

        [Obsolete]
        public async Task<PaymentSetupResponse> PaymentSessionAsync(PaymentSetupRequest paymentSetupRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/paymentSession";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentSetupResponse>(paymentSetupRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

        [Obsolete]
        public PaymentVerificationResponse VerifyPaymentResult(PaymentVerificationRequest paymentVerificationRequest, RequestOptions requestOptions = default)
        {
            return VerifyPaymentResultAsync(paymentVerificationRequest, requestOptions).GetAwaiter().GetResult();
        }

        [Obsolete]
        public async Task<PaymentVerificationResponse> VerifyPaymentResultAsync(PaymentVerificationRequest paymentVerificationRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/payments/result";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentVerificationResponse>(paymentVerificationRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

    }
    
    /// <summary>
    /// Service Interface
    /// </summary>
    public interface IClassicCheckoutSDKService
    {
        /// <summary>
        /// Create a payment session
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="paymentSetupRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentSetupResponse</returns>
        [Obsolete]
        PaymentSetupResponse PaymentSession(PaymentSetupRequest paymentSetupRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a payment session
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="paymentSetupRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of PaymentSetupResponse</returns>
        [Obsolete]
        Task<PaymentSetupResponse> PaymentSessionAsync(PaymentSetupRequest paymentSetupRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Verify a payment result
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="paymentVerificationRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentVerificationResponse</returns>
        [Obsolete]
        PaymentVerificationResponse VerifyPaymentResult(PaymentVerificationRequest paymentVerificationRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Verify a payment result
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="paymentVerificationRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of PaymentVerificationResponse</returns>
        [Obsolete]
        Task<PaymentVerificationResponse> VerifyPaymentResultAsync(PaymentVerificationRequest paymentVerificationRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
}