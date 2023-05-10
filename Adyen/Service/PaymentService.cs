/*
* Adyen Payment API
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
using System.Threading;
using System.Threading.Tasks;
using Adyen.Constants;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Payment;

namespace Adyen.Service
{
    /// <summary>
    /// DefaultService Interface
    /// </summary>
    public interface IPaymentService
    {
        /// <summary>
        /// Change the authorised amount
        /// </summary>
        /// <param name="adjustAuthorisationRequest"><see cref="AdjustAuthorisationRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ModificationResult"/>.</returns>
        ModificationResult AdjustAuthorisation(AdjustAuthorisationRequest adjustAuthorisationRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Change the authorised amount
        /// </summary>
        /// <param name="adjustAuthorisationRequest"><see cref="AdjustAuthorisationRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ModificationResult"/>.</returns>
        Task<ModificationResult> AdjustAuthorisationAsync(AdjustAuthorisationRequest adjustAuthorisationRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create an authorisation
        /// </summary>
        /// <param name="paymentRequest"><see cref="PaymentRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentResult"/>.</returns>
        PaymentResult Authorise(PaymentRequest paymentRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create an authorisation
        /// </summary>
        /// <param name="paymentRequest"><see cref="PaymentRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentResult"/>.</returns>
        Task<PaymentResult> AuthoriseAsync(PaymentRequest paymentRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Complete a 3DS authorisation
        /// </summary>
        /// <param name="paymentRequest3d"><see cref="PaymentRequest3d"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentResult"/>.</returns>
        PaymentResult Authorise3d(PaymentRequest3d paymentRequest3d, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Complete a 3DS authorisation
        /// </summary>
        /// <param name="paymentRequest3d"><see cref="PaymentRequest3d"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentResult"/>.</returns>
        Task<PaymentResult> Authorise3dAsync(PaymentRequest3d paymentRequest3d, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Complete a 3DS2 authorisation
        /// </summary>
        /// <param name="paymentRequest3ds2"><see cref="PaymentRequest3ds2"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentResult"/>.</returns>
        PaymentResult Authorise3ds2(PaymentRequest3ds2 paymentRequest3ds2, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Complete a 3DS2 authorisation
        /// </summary>
        /// <param name="paymentRequest3ds2"><see cref="PaymentRequest3ds2"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentResult"/>.</returns>
        Task<PaymentResult> Authorise3ds2Async(PaymentRequest3ds2 paymentRequest3ds2, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Cancel an authorisation
        /// </summary>
        /// <param name="cancelRequest"><see cref="CancelRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ModificationResult"/>.</returns>
        ModificationResult Cancel(CancelRequest cancelRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Cancel an authorisation
        /// </summary>
        /// <param name="cancelRequest"><see cref="CancelRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ModificationResult"/>.</returns>
        Task<ModificationResult> CancelAsync(CancelRequest cancelRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Cancel or refund a payment
        /// </summary>
        /// <param name="cancelOrRefundRequest"><see cref="CancelOrRefundRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ModificationResult"/>.</returns>
        ModificationResult CancelOrRefund(CancelOrRefundRequest cancelOrRefundRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Cancel or refund a payment
        /// </summary>
        /// <param name="cancelOrRefundRequest"><see cref="CancelOrRefundRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ModificationResult"/>.</returns>
        Task<ModificationResult> CancelOrRefundAsync(CancelOrRefundRequest cancelOrRefundRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Capture an authorisation
        /// </summary>
        /// <param name="captureRequest"><see cref="CaptureRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ModificationResult"/>.</returns>
        ModificationResult Capture(CaptureRequest captureRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Capture an authorisation
        /// </summary>
        /// <param name="captureRequest"><see cref="CaptureRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ModificationResult"/>.</returns>
        Task<ModificationResult> CaptureAsync(CaptureRequest captureRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create a donation
        /// </summary>
        /// <param name="donationRequest"><see cref="DonationRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ModificationResult"/>.</returns>
        ModificationResult Donate(DonationRequest donationRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a donation
        /// </summary>
        /// <param name="donationRequest"><see cref="DonationRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ModificationResult"/>.</returns>
        Task<ModificationResult> DonateAsync(DonationRequest donationRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get the 3DS authentication result
        /// </summary>
        /// <param name="authenticationResultRequest"><see cref="AuthenticationResultRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="AuthenticationResultResponse"/>.</returns>
        AuthenticationResultResponse GetAuthenticationResult(AuthenticationResultRequest authenticationResultRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get the 3DS authentication result
        /// </summary>
        /// <param name="authenticationResultRequest"><see cref="AuthenticationResultRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="AuthenticationResultResponse"/>.</returns>
        Task<AuthenticationResultResponse> GetAuthenticationResultAsync(AuthenticationResultRequest authenticationResultRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Refund a captured payment
        /// </summary>
        /// <param name="refundRequest"><see cref="RefundRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ModificationResult"/>.</returns>
        ModificationResult Refund(RefundRequest refundRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Refund a captured payment
        /// </summary>
        /// <param name="refundRequest"><see cref="RefundRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ModificationResult"/>.</returns>
        Task<ModificationResult> RefundAsync(RefundRequest refundRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get the 3DS2 authentication result
        /// </summary>
        /// <param name="threeDS2ResultRequest"><see cref="ThreeDS2ResultRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ThreeDS2ResultResponse"/>.</returns>
        ThreeDS2ResultResponse Retrieve3ds2Result(ThreeDS2ResultRequest threeDS2ResultRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get the 3DS2 authentication result
        /// </summary>
        /// <param name="threeDS2ResultRequest"><see cref="ThreeDS2ResultRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ThreeDS2ResultResponse"/>.</returns>
        Task<ThreeDS2ResultResponse> Retrieve3ds2ResultAsync(ThreeDS2ResultRequest threeDS2ResultRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Cancel an authorisation using your reference
        /// </summary>
        /// <param name="technicalCancelRequest"><see cref="TechnicalCancelRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ModificationResult"/>.</returns>
        ModificationResult TechnicalCancel(TechnicalCancelRequest technicalCancelRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Cancel an authorisation using your reference
        /// </summary>
        /// <param name="technicalCancelRequest"><see cref="TechnicalCancelRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ModificationResult"/>.</returns>
        Task<ModificationResult> TechnicalCancelAsync(TechnicalCancelRequest technicalCancelRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Cancel an in-person refund
        /// </summary>
        /// <param name="voidPendingRefundRequest"><see cref="VoidPendingRefundRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="ModificationResult"/>.</returns>
        ModificationResult VoidPendingRefund(VoidPendingRefundRequest voidPendingRefundRequest, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Cancel an in-person refund
        /// </summary>
        /// <param name="voidPendingRefundRequest"><see cref="VoidPendingRefundRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="ModificationResult"/>.</returns>
        Task<ModificationResult> VoidPendingRefundAsync(VoidPendingRefundRequest voidPendingRefundRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the PaymentService API endpoints
    /// </summary>
    public class PaymentService : AbstractService, IPaymentService
    {
        private readonly string _baseUrl;
        
        public PaymentService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://pal-test.adyen.com/pal/servlet/Payment/v68");
        }
        
        public ModificationResult AdjustAuthorisation(AdjustAuthorisationRequest adjustAuthorisationRequest, RequestOptions requestOptions = default)
        {
            return AdjustAuthorisationAsync(adjustAuthorisationRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ModificationResult> AdjustAuthorisationAsync(AdjustAuthorisationRequest adjustAuthorisationRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/adjustAuthorisation";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ModificationResult>(adjustAuthorisationRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public PaymentResult Authorise(PaymentRequest paymentRequest, RequestOptions requestOptions = default)
        {
            return AuthoriseAsync(paymentRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PaymentResult> AuthoriseAsync(PaymentRequest paymentRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/authorise";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentResult>(paymentRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public PaymentResult Authorise3d(PaymentRequest3d paymentRequest3d, RequestOptions requestOptions = default)
        {
            return Authorise3dAsync(paymentRequest3d, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PaymentResult> Authorise3dAsync(PaymentRequest3d paymentRequest3d, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/authorise3d";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentResult>(paymentRequest3d.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public PaymentResult Authorise3ds2(PaymentRequest3ds2 paymentRequest3ds2, RequestOptions requestOptions = default)
        {
            return Authorise3ds2Async(paymentRequest3ds2, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<PaymentResult> Authorise3ds2Async(PaymentRequest3ds2 paymentRequest3ds2, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/authorise3ds2";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentResult>(paymentRequest3ds2.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public ModificationResult Cancel(CancelRequest cancelRequest, RequestOptions requestOptions = default)
        {
            return CancelAsync(cancelRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ModificationResult> CancelAsync(CancelRequest cancelRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/cancel";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ModificationResult>(cancelRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public ModificationResult CancelOrRefund(CancelOrRefundRequest cancelOrRefundRequest, RequestOptions requestOptions = default)
        {
            return CancelOrRefundAsync(cancelOrRefundRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ModificationResult> CancelOrRefundAsync(CancelOrRefundRequest cancelOrRefundRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/cancelOrRefund";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ModificationResult>(cancelOrRefundRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public ModificationResult Capture(CaptureRequest captureRequest, RequestOptions requestOptions = default)
        {
            return CaptureAsync(captureRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ModificationResult> CaptureAsync(CaptureRequest captureRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/capture";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ModificationResult>(captureRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public ModificationResult Donate(DonationRequest donationRequest, RequestOptions requestOptions = default)
        {
            return DonateAsync(donationRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ModificationResult> DonateAsync(DonationRequest donationRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/donate";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ModificationResult>(donationRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public AuthenticationResultResponse GetAuthenticationResult(AuthenticationResultRequest authenticationResultRequest, RequestOptions requestOptions = default)
        {
            return GetAuthenticationResultAsync(authenticationResultRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<AuthenticationResultResponse> GetAuthenticationResultAsync(AuthenticationResultRequest authenticationResultRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/getAuthenticationResult";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<AuthenticationResultResponse>(authenticationResultRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public ModificationResult Refund(RefundRequest refundRequest, RequestOptions requestOptions = default)
        {
            return RefundAsync(refundRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ModificationResult> RefundAsync(RefundRequest refundRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/refund";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ModificationResult>(refundRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public ThreeDS2ResultResponse Retrieve3ds2Result(ThreeDS2ResultRequest threeDS2ResultRequest, RequestOptions requestOptions = default)
        {
            return Retrieve3ds2ResultAsync(threeDS2ResultRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ThreeDS2ResultResponse> Retrieve3ds2ResultAsync(ThreeDS2ResultRequest threeDS2ResultRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/retrieve3ds2Result";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ThreeDS2ResultResponse>(threeDS2ResultRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public ModificationResult TechnicalCancel(TechnicalCancelRequest technicalCancelRequest, RequestOptions requestOptions = default)
        {
            return TechnicalCancelAsync(technicalCancelRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ModificationResult> TechnicalCancelAsync(TechnicalCancelRequest technicalCancelRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/technicalCancel";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ModificationResult>(technicalCancelRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public ModificationResult VoidPendingRefund(VoidPendingRefundRequest voidPendingRefundRequest, RequestOptions requestOptions = default)
        {
            return VoidPendingRefundAsync(voidPendingRefundRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<ModificationResult> VoidPendingRefundAsync(VoidPendingRefundRequest voidPendingRefundRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/voidPendingRefund";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<ModificationResult>(voidPendingRefundRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}