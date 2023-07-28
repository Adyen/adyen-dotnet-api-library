/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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
    /// PaymentsService Interface
    /// </summary>
    public interface IPaymentsService
    {
        /// <summary>
        /// Get the result of a payment session
        /// </summary>
        /// <param name="sessionId"><see cref="string"/> - A unique identifier of the session.</param>
        /// <param name="sessionResult"><see cref="string"/> - The &#x60;sessionResult&#x60; value from the Drop-in or Component.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="SessionResultResponse"/>.</returns>
        Model.Checkout.SessionResultResponse GetResultOfPaymentSession(string sessionId, string sessionResult = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get the result of a payment session
        /// </summary>
        /// <param name="sessionId"><see cref="string"/> - A unique identifier of the session.</param>
        /// <param name="sessionResult"><see cref="string"/> - The &#x60;sessionResult&#x60; value from the Drop-in or Component.</param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="SessionResultResponse"/>.</returns>
        Task<Model.Checkout.SessionResultResponse> GetResultOfPaymentSessionAsync(string sessionId, string sessionResult = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get the list of brands on the card
        /// </summary>
        /// <param name="cardDetailsRequest"><see cref="CardDetailsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CardDetailsResponse"/>.</returns>
        Model.Checkout.CardDetailsResponse CardDetails(CardDetailsRequest cardDetailsRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get the list of brands on the card
        /// </summary>
        /// <param name="cardDetailsRequest"><see cref="CardDetailsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CardDetailsResponse"/>.</returns>
        Task<Model.Checkout.CardDetailsResponse> CardDetailsAsync(CardDetailsRequest cardDetailsRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Start a transaction for donations
        /// </summary>
        /// <param name="donationPaymentRequest"><see cref="DonationPaymentRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="DonationPaymentResponse"/>.</returns>
        Model.Checkout.DonationPaymentResponse Donations(DonationPaymentRequest donationPaymentRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Start a transaction for donations
        /// </summary>
        /// <param name="donationPaymentRequest"><see cref="DonationPaymentRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="DonationPaymentResponse"/>.</returns>
        Task<Model.Checkout.DonationPaymentResponse> DonationsAsync(DonationPaymentRequest donationPaymentRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Get a list of available payment methods
        /// </summary>
        /// <param name="paymentMethodsRequest"><see cref="PaymentMethodsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentMethodsResponse"/>.</returns>
        Model.Checkout.PaymentMethodsResponse PaymentMethods(PaymentMethodsRequest paymentMethodsRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Get a list of available payment methods
        /// </summary>
        /// <param name="paymentMethodsRequest"><see cref="PaymentMethodsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentMethodsResponse"/>.</returns>
        Task<Model.Checkout.PaymentMethodsResponse> PaymentMethodsAsync(PaymentMethodsRequest paymentMethodsRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Start a transaction
        /// </summary>
        /// <param name="paymentRequest"><see cref="PaymentRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentResponse"/>.</returns>
        Model.Checkout.PaymentResponse Payments(PaymentRequest paymentRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Start a transaction
        /// </summary>
        /// <param name="paymentRequest"><see cref="PaymentRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentResponse"/>.</returns>
        Task<Model.Checkout.PaymentResponse> PaymentsAsync(PaymentRequest paymentRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Submit details for a payment
        /// </summary>
        /// <param name="paymentDetailsRequest"><see cref="PaymentDetailsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="PaymentDetailsResponse"/>.</returns>
        Model.Checkout.PaymentDetailsResponse PaymentsDetails(PaymentDetailsRequest paymentDetailsRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Submit details for a payment
        /// </summary>
        /// <param name="paymentDetailsRequest"><see cref="PaymentDetailsRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="PaymentDetailsResponse"/>.</returns>
        Task<Model.Checkout.PaymentDetailsResponse> PaymentsDetailsAsync(PaymentDetailsRequest paymentDetailsRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Create a payment session
        /// </summary>
        /// <param name="createCheckoutSessionRequest"><see cref="CreateCheckoutSessionRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <returns><see cref="CreateCheckoutSessionResponse"/>.</returns>
        Model.Checkout.CreateCheckoutSessionResponse Sessions(CreateCheckoutSessionRequest createCheckoutSessionRequest = default, RequestOptions requestOptions = default);
        
        /// <summary>
        /// Create a payment session
        /// </summary>
        /// <param name="createCheckoutSessionRequest"><see cref="CreateCheckoutSessionRequest"/> - </param>
        /// <param name="requestOptions"><see cref="RequestOptions"/> - Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of <see cref="CreateCheckoutSessionResponse"/>.</returns>
        Task<Model.Checkout.CreateCheckoutSessionResponse> SessionsAsync(CreateCheckoutSessionRequest createCheckoutSessionRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        
    }
    
    /// <summary>
    /// Represents a collection of functions to interact with the PaymentsService API endpoints
    /// </summary>
    public class PaymentsService : AbstractService, IPaymentsService
    {
        private readonly string _baseUrl;
        
        public PaymentsService(Client client) : base(client)
        {
            _baseUrl = CreateBaseUrl("https://checkout-test.adyen.com/v70");
        }
        
        public Model.Checkout.SessionResultResponse GetResultOfPaymentSession(string sessionId, string sessionResult = default, RequestOptions requestOptions = default)
        {
            return GetResultOfPaymentSessionAsync(sessionId, sessionResult, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.SessionResultResponse> GetResultOfPaymentSessionAsync(string sessionId, string sessionResult = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            // Build the query string
            var queryParams = new Dictionary<string, string>();
            if (sessionResult != null) queryParams.Add("sessionResult", sessionResult);
            var endpoint = _baseUrl + $"/sessions/{sessionId}" + ToQueryString(queryParams);
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.SessionResultResponse>(null, requestOptions, new HttpMethod("GET"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Checkout.CardDetailsResponse CardDetails(CardDetailsRequest cardDetailsRequest = default, RequestOptions requestOptions = default)
        {
            return CardDetailsAsync(cardDetailsRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.CardDetailsResponse> CardDetailsAsync(CardDetailsRequest cardDetailsRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/cardDetails";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.CardDetailsResponse>(cardDetailsRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Checkout.DonationPaymentResponse Donations(DonationPaymentRequest donationPaymentRequest = default, RequestOptions requestOptions = default)
        {
            return DonationsAsync(donationPaymentRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.DonationPaymentResponse> DonationsAsync(DonationPaymentRequest donationPaymentRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/donations";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.DonationPaymentResponse>(donationPaymentRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Checkout.PaymentMethodsResponse PaymentMethods(PaymentMethodsRequest paymentMethodsRequest = default, RequestOptions requestOptions = default)
        {
            return PaymentMethodsAsync(paymentMethodsRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.PaymentMethodsResponse> PaymentMethodsAsync(PaymentMethodsRequest paymentMethodsRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/paymentMethods";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.PaymentMethodsResponse>(paymentMethodsRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Checkout.PaymentResponse Payments(PaymentRequest paymentRequest = default, RequestOptions requestOptions = default)
        {
            return PaymentsAsync(paymentRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.PaymentResponse> PaymentsAsync(PaymentRequest paymentRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/payments";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.PaymentResponse>(paymentRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Checkout.PaymentDetailsResponse PaymentsDetails(PaymentDetailsRequest paymentDetailsRequest = default, RequestOptions requestOptions = default)
        {
            return PaymentsDetailsAsync(paymentDetailsRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.PaymentDetailsResponse> PaymentsDetailsAsync(PaymentDetailsRequest paymentDetailsRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/payments/details";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.PaymentDetailsResponse>(paymentDetailsRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
        
        public Model.Checkout.CreateCheckoutSessionResponse Sessions(CreateCheckoutSessionRequest createCheckoutSessionRequest = default, RequestOptions requestOptions = default)
        {
            return SessionsAsync(createCheckoutSessionRequest, requestOptions).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<Model.Checkout.CreateCheckoutSessionResponse> SessionsAsync(CreateCheckoutSessionRequest createCheckoutSessionRequest = default, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/sessions";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<Model.Checkout.CreateCheckoutSessionResponse>(createCheckoutSessionRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken).ConfigureAwait(false);
        }
    }
}