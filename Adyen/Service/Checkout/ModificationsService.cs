/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 71
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
using Adyen.Model.Checkout;

namespace Adyen.Service.Checkout
{
    /// <summary>
    /// ModificationsService Interface
    /// </summary>
    public interface IModificationsService
    {
        /// <summary>
        /// Cancel an authorised payment
        /// </summary>
        /// <param name="standalonePaymentCancelRequest"><see cref="StandalonePaymentCancelRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="StandalonePaymentCancelResponse"/>.</returns>
        Model.Checkout.StandalonePaymentCancelResponse CancelAuthorisedPayment(StandalonePaymentCancelRequest standalonePaymentCancelRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Cancel an authorised payment
        /// </summary>
        /// <param name="standalonePaymentCancelRequest"><see cref="StandalonePaymentCancelRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="StandalonePaymentCancelResponse"/>.</returns>
        Task<Model.Checkout.StandalonePaymentCancelResponse> CancelAuthorisedPaymentAsync(StandalonePaymentCancelRequest standalonePaymentCancelRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Update an authorised amount
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment.</param>
        /// <param name="paymentAmountUpdateRequest"><see cref="PaymentAmountUpdateRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentAmountUpdateResponse"/>.</returns>
        Model.Checkout.PaymentAmountUpdateResponse UpdateAuthorisedAmount(string paymentPspReference, PaymentAmountUpdateRequest paymentAmountUpdateRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Update an authorised amount
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment.</param>
        /// <param name="paymentAmountUpdateRequest"><see cref="PaymentAmountUpdateRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentAmountUpdateResponse"/>.</returns>
        Task<Model.Checkout.PaymentAmountUpdateResponse> UpdateAuthorisedAmountAsync(string paymentPspReference, PaymentAmountUpdateRequest paymentAmountUpdateRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Cancel an authorised payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to cancel. </param>
        /// <param name="paymentCancelRequest"><see cref="PaymentCancelRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentCancelResponse"/>.</returns>
        Model.Checkout.PaymentCancelResponse CancelAuthorisedPaymentByPspReference(string paymentPspReference, PaymentCancelRequest paymentCancelRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Cancel an authorised payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to cancel. </param>
        /// <param name="paymentCancelRequest"><see cref="PaymentCancelRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentCancelResponse"/>.</returns>
        Task<Model.Checkout.PaymentCancelResponse> CancelAuthorisedPaymentByPspReferenceAsync(string paymentPspReference, PaymentCancelRequest paymentCancelRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Capture an authorised payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to capture.</param>
        /// <param name="paymentCaptureRequest"><see cref="PaymentCaptureRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentCaptureResponse"/>.</returns>
        Model.Checkout.PaymentCaptureResponse CaptureAuthorisedPayment(string paymentPspReference, PaymentCaptureRequest paymentCaptureRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Capture an authorised payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to capture.</param>
        /// <param name="paymentCaptureRequest"><see cref="PaymentCaptureRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentCaptureResponse"/>.</returns>
        Task<Model.Checkout.PaymentCaptureResponse> CaptureAuthorisedPaymentAsync(string paymentPspReference, PaymentCaptureRequest paymentCaptureRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Refund a captured payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to refund.</param>
        /// <param name="paymentRefundRequest"><see cref="PaymentRefundRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentRefundResponse"/>.</returns>
        Model.Checkout.PaymentRefundResponse RefundCapturedPayment(string paymentPspReference, PaymentRefundRequest paymentRefundRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Refund a captured payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to refund.</param>
        /// <param name="paymentRefundRequest"><see cref="PaymentRefundRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentRefundResponse"/>.</returns>
        Task<Model.Checkout.PaymentRefundResponse> RefundCapturedPaymentAsync(string paymentPspReference, PaymentRefundRequest paymentRefundRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Refund or cancel a payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to reverse. </param>
        /// <param name="paymentReversalRequest"><see cref="PaymentReversalRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentReversalResponse"/>.</returns>
        Model.Checkout.PaymentReversalResponse RefundOrCancelPayment(string paymentPspReference, PaymentReversalRequest paymentReversalRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Refund or cancel a payment
        /// </summary>
        /// <param name="paymentPspReference"><see cref="string"/> - The [&#x60;pspReference&#x60;](https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments__resParam_pspReference) of the payment that you want to reverse. </param>
        /// <param name="paymentReversalRequest"><see cref="PaymentReversalRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentReversalResponse"/>.</returns>
        Task<Model.Checkout.PaymentReversalResponse> RefundOrCancelPaymentAsync(string paymentPspReference, PaymentReversalRequest paymentReversalRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the ModificationsService API endpoints
    /// </summary>
    public class ModificationsService : AbstractService, IModificationsService
    {
        private readonly string _baseUrl;
        
        public ModificationsService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://checkout-test.adyen.com/v71");
        }
        
        public Model.Checkout.StandalonePaymentCancelResponse CancelAuthorisedPayment(StandalonePaymentCancelRequest standalonePaymentCancelRequest = default, RequestOptions requestOptions = default)
        {
            return CancelAuthorisedPaymentAsync(standalonePaymentCancelRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.StandalonePaymentCancelResponse> CancelAuthorisedPaymentAsync(StandalonePaymentCancelRequest standalonePaymentCancelRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/cancels";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.StandalonePaymentCancelResponse>(standalonePaymentCancelRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Checkout.PaymentAmountUpdateResponse UpdateAuthorisedAmount(string paymentPspReference, PaymentAmountUpdateRequest paymentAmountUpdateRequest = default, RequestOptions requestOptions = default)
        {
            return UpdateAuthorisedAmountAsync(paymentPspReference, paymentAmountUpdateRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.PaymentAmountUpdateResponse> UpdateAuthorisedAmountAsync(string paymentPspReference, PaymentAmountUpdateRequest paymentAmountUpdateRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/amountUpdates";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.PaymentAmountUpdateResponse>(paymentAmountUpdateRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Checkout.PaymentCancelResponse CancelAuthorisedPaymentByPspReference(string paymentPspReference, PaymentCancelRequest paymentCancelRequest = default, RequestOptions requestOptions = default)
        {
            return CancelAuthorisedPaymentByPspReferenceAsync(paymentPspReference, paymentCancelRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.PaymentCancelResponse> CancelAuthorisedPaymentByPspReferenceAsync(string paymentPspReference, PaymentCancelRequest paymentCancelRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/cancels";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.PaymentCancelResponse>(paymentCancelRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Checkout.PaymentCaptureResponse CaptureAuthorisedPayment(string paymentPspReference, PaymentCaptureRequest paymentCaptureRequest = default, RequestOptions requestOptions = default)
        {
            return CaptureAuthorisedPaymentAsync(paymentPspReference, paymentCaptureRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.PaymentCaptureResponse> CaptureAuthorisedPaymentAsync(string paymentPspReference, PaymentCaptureRequest paymentCaptureRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/captures";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.PaymentCaptureResponse>(paymentCaptureRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Checkout.PaymentRefundResponse RefundCapturedPayment(string paymentPspReference, PaymentRefundRequest paymentRefundRequest = default, RequestOptions requestOptions = default)
        {
            return RefundCapturedPaymentAsync(paymentPspReference, paymentRefundRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.PaymentRefundResponse> RefundCapturedPaymentAsync(string paymentPspReference, PaymentRefundRequest paymentRefundRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/refunds";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.PaymentRefundResponse>(paymentRefundRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Checkout.PaymentReversalResponse RefundOrCancelPayment(string paymentPspReference, PaymentReversalRequest paymentReversalRequest = default, RequestOptions requestOptions = default)
        {
            return RefundOrCancelPaymentAsync(paymentPspReference, paymentReversalRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.PaymentReversalResponse> RefundOrCancelPaymentAsync(string paymentPspReference, PaymentReversalRequest paymentReversalRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + $"/payments/{paymentPspReference}/reversals";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.PaymentReversalResponse>(paymentReversalRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}