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
    public class PaymentsService : AbstractService, IPaymentsService
    {
        private readonly string _baseUrl;
        
        public PaymentsService(Client client) : base(client)
        {
            _baseUrl = client.Config.CheckoutEndpoint + "/" + ClientConfig.CheckoutApiVersion;
        }
    
        public CardDetailsResponse CardDetails(CardDetailsRequest cardDetailsRequest, RequestOptions requestOptions = default)
        {
            return CardDetailsAsync(cardDetailsRequest, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<CardDetailsResponse> CardDetailsAsync(CardDetailsRequest cardDetailsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/cardDetails";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CardDetailsResponse>(cardDetailsRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

        public DonationResponse Donations(PaymentDonationRequest paymentDonationRequest, RequestOptions requestOptions = default)
        {
            return DonationsAsync(paymentDonationRequest, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<DonationResponse> DonationsAsync(PaymentDonationRequest paymentDonationRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/donations";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<DonationResponse>(paymentDonationRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

        public PaymentMethodsResponse PaymentMethods(PaymentMethodsRequest paymentMethodsRequest, RequestOptions requestOptions = default)
        {
            return PaymentMethodsAsync(paymentMethodsRequest, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<PaymentMethodsResponse> PaymentMethodsAsync(PaymentMethodsRequest paymentMethodsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/paymentMethods";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentMethodsResponse>(paymentMethodsRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

        public PaymentResponse Payments(PaymentRequest paymentRequest, RequestOptions requestOptions = default)
        {
            return PaymentsAsync(paymentRequest, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<PaymentResponse> PaymentsAsync(PaymentRequest paymentRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/payments";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentResponse>(paymentRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

        public PaymentDetailsResponse PaymentsDetails(DetailsRequest detailsRequest, RequestOptions requestOptions = default)
        {
            return PaymentsDetailsAsync(detailsRequest, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<PaymentDetailsResponse> PaymentsDetailsAsync(DetailsRequest detailsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/payments/details";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<PaymentDetailsResponse>(detailsRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

        public CreateCheckoutSessionResponse Sessions(CreateCheckoutSessionRequest createCheckoutSessionRequest, RequestOptions requestOptions = default)
        {
            return SessionsAsync(createCheckoutSessionRequest, requestOptions).GetAwaiter().GetResult();
        }

        public async Task<CreateCheckoutSessionResponse> SessionsAsync(CreateCheckoutSessionRequest createCheckoutSessionRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default)
        {
            var endpoint = _baseUrl + "/sessions";
            var resource = new ServiceResource(this, endpoint);
            return await resource.RequestAsync<CreateCheckoutSessionResponse>(createCheckoutSessionRequest.ToJson(), requestOptions, new HttpMethod("POST"), cancellationToken);
        }

    }
}

interface IPaymentsService
{   
        /// <summary>
        /// Get the list of brands on the card
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="cardDetailsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>CardDetailsResponse</returns>
        CardDetailsResponse CardDetails(CardDetailsRequest cardDetailsRequest, RequestOptions requestOptions = default);
        /// <summary>
        /// Get the list of brands on the card
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="cardDetailsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of CardDetailsResponse</returns>
        Task<CardDetailsResponse> CardDetailsAsync(CardDetailsRequest cardDetailsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a transaction for donations
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="paymentDonationRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>DonationResponse</returns>
        DonationResponse Donations(PaymentDonationRequest paymentDonationRequest, RequestOptions requestOptions = default);
        /// <summary>
        /// Start a transaction for donations
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="paymentDonationRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of DonationResponse</returns>
        Task<DonationResponse> DonationsAsync(PaymentDonationRequest paymentDonationRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a list of available payment methods
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="paymentMethodsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentMethodsResponse</returns>
        PaymentMethodsResponse PaymentMethods(PaymentMethodsRequest paymentMethodsRequest, RequestOptions requestOptions = default);
        /// <summary>
        /// Get a list of available payment methods
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="paymentMethodsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of PaymentMethodsResponse</returns>
        Task<PaymentMethodsResponse> PaymentMethodsAsync(PaymentMethodsRequest paymentMethodsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Start a transaction
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="paymentRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentResponse</returns>
        PaymentResponse Payments(PaymentRequest paymentRequest, RequestOptions requestOptions = default);
        /// <summary>
        /// Start a transaction
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="paymentRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of PaymentResponse</returns>
        Task<PaymentResponse> PaymentsAsync(PaymentRequest paymentRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit details for a payment
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="detailsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentDetailsResponse</returns>
        PaymentDetailsResponse PaymentsDetails(DetailsRequest detailsRequest, RequestOptions requestOptions = default);
        /// <summary>
        /// Submit details for a payment
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="detailsRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of PaymentDetailsResponse</returns>
        Task<PaymentDetailsResponse> PaymentsDetailsAsync(DetailsRequest detailsRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a payment session
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createCheckoutSessionRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>CreateCheckoutSessionResponse</returns>
        CreateCheckoutSessionResponse Sessions(CreateCheckoutSessionRequest createCheckoutSessionRequest, RequestOptions requestOptions = default);
        /// <summary>
        /// Create a payment session
        /// </summary>
        /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
        /// <param name="createCheckoutSessionRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <param name="cancellationToken"> A CancellationToken enables cooperative cancellation between threads, thread pool work items, or Task objects.</param>
        /// <returns>Task of CreateCheckoutSessionResponse</returns>
        Task<CreateCheckoutSessionResponse> SessionsAsync(CreateCheckoutSessionRequest createCheckoutSessionRequest, RequestOptions requestOptions = default, CancellationToken cancellationToken = default);
}
