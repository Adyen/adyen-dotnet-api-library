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
    public class ModificationsService : AbstractService
    {
        private readonly string _baseUrl;
        
        public ModificationsService(Client client) : base(client)
        {
            _baseUrl = client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion;
        }
    
        /// <summary>
        /// Cancel an authorised payment
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createStandalonePaymentCancelRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>StandalonePaymentCancelResource</returns>
        public StandalonePaymentCancelResource CancelAuthorisedPayment(CreateStandalonePaymentCancelRequest createStandalonePaymentCancelRequest, RequestOptions requestOptions = default
)
        {
            return CancelAuthorisedPaymentAsync(createStandalonePaymentCancelRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cancel an authorised payment
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createStandalonePaymentCancelRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of StandalonePaymentCancelResource</returns>
        public async Task<StandalonePaymentCancelResource> CancelAuthorisedPaymentAsync(CreateStandalonePaymentCancelRequest createStandalonePaymentCancelRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/cancels";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<StandalonePaymentCancelResource>(createStandalonePaymentCancelRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

        /// <summary>
        /// Update an authorised amount
        /// </summary>
        /// <param name="paymentPspReference">The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment.</param>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createPaymentAmountUpdateRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentAmountUpdateResource</returns>
        public PaymentAmountUpdateResource UpdateAuthorisedAmount(string paymentPspReference, CreatePaymentAmountUpdateRequest createPaymentAmountUpdateRequest, RequestOptions requestOptions = default
)
        {
            return UpdateAuthorisedAmountAsync(paymentPspReference, createPaymentAmountUpdateRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update an authorised amount
        /// </summary>
        /// <param name="paymentPspReference">The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment.</param>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createPaymentAmountUpdateRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of PaymentAmountUpdateResource</returns>
        public async Task<PaymentAmountUpdateResource> UpdateAuthorisedAmountAsync(string paymentPspReference, CreatePaymentAmountUpdateRequest createPaymentAmountUpdateRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/amountUpdates";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentAmountUpdateResource>(createPaymentAmountUpdateRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

        /// <summary>
        /// Cancel an authorised payment
        /// </summary>
        /// <param name="paymentPspReference">The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to cancel. </param>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createPaymentCancelRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentCancelResource</returns>
        public PaymentCancelResource CancelAuthorisedPaymentByPspReference(string paymentPspReference, CreatePaymentCancelRequest createPaymentCancelRequest, RequestOptions requestOptions = default
)
        {
            return CancelAuthorisedPaymentByPspReferenceAsync(paymentPspReference, createPaymentCancelRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Cancel an authorised payment
        /// </summary>
        /// <param name="paymentPspReference">The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to cancel. </param>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createPaymentCancelRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of PaymentCancelResource</returns>
        public async Task<PaymentCancelResource> CancelAuthorisedPaymentByPspReferenceAsync(string paymentPspReference, CreatePaymentCancelRequest createPaymentCancelRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/cancels";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentCancelResource>(createPaymentCancelRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

        /// <summary>
        /// Capture an authorised payment
        /// </summary>
        /// <param name="paymentPspReference">The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to capture.</param>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createPaymentCaptureRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentCaptureResource</returns>
        public PaymentCaptureResource CaptureAuthorisedPayment(string paymentPspReference, CreatePaymentCaptureRequest createPaymentCaptureRequest, RequestOptions requestOptions = default
)
        {
            return CaptureAuthorisedPaymentAsync(paymentPspReference, createPaymentCaptureRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Capture an authorised payment
        /// </summary>
        /// <param name="paymentPspReference">The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to capture.</param>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createPaymentCaptureRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of PaymentCaptureResource</returns>
        public async Task<PaymentCaptureResource> CaptureAuthorisedPaymentAsync(string paymentPspReference, CreatePaymentCaptureRequest createPaymentCaptureRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/captures";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentCaptureResource>(createPaymentCaptureRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

        /// <summary>
        /// Refund a captured payment
        /// </summary>
        /// <param name="paymentPspReference">The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to refund.</param>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createPaymentRefundRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentRefundResource</returns>
        public PaymentRefundResource RefundCapturedPayment(string paymentPspReference, CreatePaymentRefundRequest createPaymentRefundRequest, RequestOptions requestOptions = default
)
        {
            return RefundCapturedPaymentAsync(paymentPspReference, createPaymentRefundRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Refund a captured payment
        /// </summary>
        /// <param name="paymentPspReference">The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to refund.</param>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createPaymentRefundRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of PaymentRefundResource</returns>
        public async Task<PaymentRefundResource> RefundCapturedPaymentAsync(string paymentPspReference, CreatePaymentRefundRequest createPaymentRefundRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/refunds";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentRefundResource>(createPaymentRefundRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

        /// <summary>
        /// Refund or cancel a payment
        /// </summary>
        /// <param name="paymentPspReference">The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to reverse. </param>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createPaymentReversalRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentReversalResource</returns>
        public PaymentReversalResource RefundOrCancelPayment(string paymentPspReference, CreatePaymentReversalRequest createPaymentReversalRequest, RequestOptions requestOptions = default
)
        {
            return RefundOrCancelPaymentAsync(paymentPspReference, createPaymentReversalRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Refund or cancel a payment
        /// </summary>
        /// <param name="paymentPspReference">The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to reverse. </param>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createPaymentReversalRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of PaymentReversalResource</returns>
        public async Task<PaymentReversalResource> RefundOrCancelPaymentAsync(string paymentPspReference, CreatePaymentReversalRequest createPaymentReversalRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/reversals";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentReversalResource>(createPaymentReversalRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

    }
}
