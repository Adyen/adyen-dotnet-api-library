#region License
/*
 *                       ######
 *                       ######
 * ############    ####( ######  #####. ######  ############   ############
 * #############  #####( ######  #####. ######  #############  #############
 *        ######  #####( ######  #####. ######  #####  ######  #####  ######
 * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
 * ###### ######  #####( ######  #####. ######  #####          #####  ######
 * #############  #############  #############  #############  #####  ######
 *  ############   ############  #############   ############  #####  ######
 *                                      ######
 *                               #############
 *                               ############
 *
 * Adyen Dotnet API Library
 *
 * Copyright (c) 2022 Adyen N.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion

using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Model.Checkout;
using Adyen.Service.Resource.Checkout;
using CardDetails = Adyen.Service.Resource.Checkout.CardDetails;
using PaymentDetails = Adyen.Service.Resource.Checkout.PaymentDetails;
using PaymentRequest = Adyen.Model.Checkout.PaymentRequest;
using RequestOptions = Adyen.Model.RequestOptions;

namespace Adyen.Service
{
    public class Checkout : AbstractService
    {
        private readonly Payments _payments;
        private readonly PaymentMethods _paymentMethods;
        private readonly PaymentDetails _paymentDetails;
        private readonly PaymentSession _paymentSession;
        private readonly PaymentsResult _paymentsResult;
        private readonly PaymentLinks _paymentLinksResult;
        private readonly Sessions _sessions;
        private readonly Orders _orders;
        private readonly OrdersCancel _ordersCancel;
        private readonly PaymentMethodsBalance _paymentMethodsBalance;
        private readonly Cancels _cancels;
        private readonly Donations _donations;
        private readonly CardDetails _cardDetails;
        private readonly CheckoutResource _applePaySessions;
        public Checkout(Client client) : base(client)
        {
            _payments = new Payments(this);
            _paymentMethods = new PaymentMethods(this);
            _paymentDetails = new PaymentDetails(this);
            _paymentSession = new PaymentSession(this);
            _paymentsResult = new PaymentsResult(this);
            _paymentLinksResult = new PaymentLinks(this, null);
            _sessions = new Sessions(this);
            _orders = new Orders(this);
            _ordersCancel = new OrdersCancel(this);
            _paymentMethodsBalance = new PaymentMethodsBalance(this);
            _cancels = new Cancels(this);
            _donations = new Donations(this);
            _cardDetails = new CardDetails(this);
            _applePaySessions = new CheckoutResource(this, "/applePay/sessions");
        }

        /// <summary>
        /// Post /payments API call
        /// </summary>
        /// <param name="paymentRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public PaymentResponse Payments(PaymentRequest paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            return _payments.Request<PaymentResponse>(jsonRequest, requestOptions);
        }

        /// <summary>
        /// Post /payments API call async
        /// </summary>
        /// <param name="paymentRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public async Task<PaymentResponse> PaymentsAsync(PaymentRequest paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentRequest.ToJson();
            return await _payments.RequestAsync<PaymentResponse>(jsonRequest, requestOptions);
        }

        /// <summary>
        /// POST /paymentMethods API call
        /// </summary>
        /// <param name="paymentMethodsRequest"></param>
        /// <returns>PaymentMethodsResponse</returns>
        public PaymentMethodsResponse PaymentMethods(PaymentMethodsRequest paymentMethodsRequest)
        {
            var jsonRequest = paymentMethodsRequest.ToJson();
            return _paymentMethods.Request<PaymentMethodsResponse>(jsonRequest);
        }

        /// <summary>
        /// POST /paymentMethods API call async
        /// </summary>
        /// <param name="paymentMethodsRequest"></param>
        /// <returns>PaymentMethodsResponse</returns>
        public async Task<PaymentMethodsResponse> PaymentMethodsAsync(PaymentMethodsRequest paymentMethodsRequest)
        {
            var jsonRequest = paymentMethodsRequest.ToJson();
            return await _paymentMethods.RequestAsync<PaymentMethodsResponse>(jsonRequest);
        }

        /// <summary>
        ///  POST payments/details API call
        /// </summary>
        /// <param name="paymentsDetailsRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public PaymentDetailsResponse PaymentDetails(DetailsRequest paymentsDetailsRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = paymentsDetailsRequest.ToJson();
            return _paymentDetails.Request<PaymentDetailsResponse>(jsonRequest, requestOptions);
        }

        /// <summary>
        ///  POST payments/details API call async
        /// </summary>
        /// <param name="paymentsDetailsRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentDetailsResponse</returns>
        public async Task<PaymentDetailsResponse> PaymentDetailsAsync(DetailsRequest paymentsDetailsRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = (paymentsDetailsRequest).ToJson();
            return await _paymentDetails.RequestAsync<PaymentDetailsResponse>(jsonRequest, requestOptions);
        }

        /// <summary>
        /// POST /paymentSession API call
        /// </summary>
        /// <param name="paymentSetupRequest"></param>
        /// <returns>PaymentSessionResponse</returns>
        public PaymentSetupResponse PaymentSession(PaymentSetupRequest paymentSetupRequest)
        {
            var jsonRequest = paymentSetupRequest.ToJson();
            return _paymentSession.Request<PaymentSetupResponse>(jsonRequest);
        }

        /// <summary>
        /// POST /paymentSession API call async
        /// </summary>
        /// <param name="paymentSetupRequest"></param>
        /// <returns>PaymentSetupResponse</returns>
        public async Task<PaymentSetupResponse> PaymentSessionAsync(PaymentSetupRequest paymentSetupRequest)
        {
            var jsonRequest = paymentSetupRequest.ToJson();
            return await _paymentSession.RequestAsync<PaymentSetupResponse>(jsonRequest);
        }

        /// <summary>
        /// POST payments/result API call
        /// </summary>
        /// <param name="paymentVerificationRequest"></param>
        /// <returns>PaymentVerificationResponse</returns>
        public PaymentVerificationResponse PaymentsResult(PaymentVerificationRequest paymentVerificationRequest)
        {
            var jsonRequest = paymentVerificationRequest.ToJson();
            return _paymentsResult.Request<PaymentVerificationResponse>(jsonRequest);
        }

        /// <summary>
        /// POST payments/result API call async
        /// </summary>
        /// <param name="paymentVerificationRequest"></param>
        /// <returns>PaymentVerificationResponse</returns>
        public async Task<PaymentVerificationResponse> PaymentsResultAsync(PaymentVerificationRequest paymentVerificationRequest)
        {
            var jsonRequest = paymentVerificationRequest.ToJson();
            return await _paymentsResult.RequestAsync<PaymentVerificationResponse>(jsonRequest);
        }

        /// <summary>
        /// POST /paymentsLinks API call 
        /// </summary>
        /// <param name="createPaymentLinkRequest"></param>
        /// <returns>PaymentLinkResponse</returns>
        public PaymentLinkResponse PaymentLinks(CreatePaymentLinkRequest createPaymentLinkRequest)
        {
            var jsonRequest = createPaymentLinkRequest.ToJson();
            return _paymentLinksResult.Request<PaymentLinkResponse>(jsonRequest);
        }
        
        /// <summary>
        /// POST /paymentsLinks API call async
        /// </summary>
        /// <param name="createPaymentLinkRequest"></param>
        /// <returns>PaymentLinkResponse</returns>
        public async Task<PaymentLinkResponse> PaymentLinksAsync(CreatePaymentLinkRequest createPaymentLinkRequest)
        {
            var jsonRequest = createPaymentLinkRequest.ToJson();
            return await _paymentLinksResult.RequestAsync<PaymentLinkResponse>(jsonRequest);
        }
        
        /// <summary>
        /// GET /paymentsLinks API call 
        /// </summary>
        /// <param name="linkId"></param>
        /// <returns>PaymentLinkResponse</returns>
        public PaymentLinkResponse GetPaymentLinks(string linkId)
        {
            linkId = "/" + linkId;
            var paymentLinks = new PaymentLinks(this, linkId);
            return paymentLinks.Request<PaymentLinkResponse>(null, null, HttpMethod.Get);
        }
        
        /// <summary>
        /// GET /paymentsLinks API call async
        /// </summary>
        /// <param name="linkId"></param>
        /// <returns>PaymentLinkResponse</returns>
        public async Task<PaymentLinkResponse> GetPaymentLinksAsync(string linkId)
        {
            linkId = "/" + linkId;
            var paymentLinks = new PaymentLinks(this, linkId);
            return await paymentLinks.RequestAsync<PaymentLinkResponse>(null, null, HttpMethod.Get);
        }
        
        /// <summary>
        /// PATCH /paymentsLinks API call 
        /// </summary>
        /// <param name="updatePaymentLinkRequest"></param>
        /// <param name="linkId"></param>
        /// <returns>PaymentLinkResponse</returns>
        public PaymentLinkResponse PatchPaymentLinks(UpdatePaymentLinkRequest updatePaymentLinkRequest, string linkId)
        {
            linkId = "/" + linkId;
            var paymentLinks = new PaymentLinks(this, linkId);
            var jsonRequest = updatePaymentLinkRequest.ToJson();
            var patch = new HttpMethod("PATCH");
            return paymentLinks.Request<PaymentLinkResponse>(jsonRequest, null, patch);
        }
        
        /// <summary>
        /// PATCH /paymentsLinks API call async 
        /// </summary>
        /// <param name="updatePaymentLinkRequest"></param>
        /// <param name="linkId"></param>
        /// <returns>PaymentLinkResponse</returns>
        public async Task<PaymentLinkResponse> PatchPaymentLinksAsync(UpdatePaymentLinkRequest updatePaymentLinkRequest, string linkId)
        {
            linkId = "/" + linkId;
            var paymentLinks = new PaymentLinks(this, linkId);
            var jsonRequest = updatePaymentLinkRequest.ToJson();
            var patch = new HttpMethod("PATCH");
            return await paymentLinks.RequestAsync<PaymentLinkResponse>(jsonRequest, null, patch);
        }

        /// <summary>
        /// POST /sessions API call 
        /// </summary>
        /// <param name="createCheckoutSessionRequest"></param>
        /// <returns>CreateCheckoutSessionResponse</returns>
        public CreateCheckoutSessionResponse Sessions(CreateCheckoutSessionRequest createCheckoutSessionRequest)
        {
            var jsonRequest = createCheckoutSessionRequest.ToJson();
            return _sessions.Request<CreateCheckoutSessionResponse>(jsonRequest);
        }

        /// <summary>
        /// POST /sessions API call async
        /// </summary>
        /// <param name="createCheckoutSessionRequest"></param>
        /// <returns>CreateCheckoutSessionResponse</returns>
        public async Task<CreateCheckoutSessionResponse> SessionsAsync(CreateCheckoutSessionRequest createCheckoutSessionRequest)
        {
            var jsonRequest = createCheckoutSessionRequest.ToJson();
            return await _sessions.RequestAsync<CreateCheckoutSessionResponse>(jsonRequest);
        }

        /// <summary>
        /// POST /paymentMethods/balance API call sync
        /// </summary>
        /// <param name="checkoutBalanceCheckRequest"></param>
        /// <returns>CheckoutBalanceCheckResponse</returns>
        public CheckoutBalanceCheckResponse PaymentMethodsBalance(CheckoutBalanceCheckRequest checkoutBalanceCheckRequest)
        {
            var jsonRequest = checkoutBalanceCheckRequest.ToJson();
            return _paymentMethodsBalance.Request<CheckoutBalanceCheckResponse>(jsonRequest);
        }

        /// <summary>
        /// POST /paymentMethods/balance API call async
        /// </summary>
        /// <param name="checkoutBalanceCheckRequest"></param>
        /// <returns>CheckoutBalanceCheckResponse</returns>
        public async Task<CheckoutBalanceCheckResponse> PaymentMethodsBalanceAsync(CheckoutBalanceCheckRequest checkoutBalanceCheckRequest)
        {
            var jsonRequest = checkoutBalanceCheckRequest.ToJson();
            return await _paymentMethodsBalance.RequestAsync<CheckoutBalanceCheckResponse>(jsonRequest);
        }

        /// <summary>
        /// POST /orders API call sync
        /// </summary>
        /// <param name="checkoutCreateOrderRequest"></param>
        /// <returns>CheckoutCreateOrderResponse</returns>
        public CheckoutCreateOrderResponse Orders(CheckoutCreateOrderRequest checkoutCreateOrderRequest)
        {
            var jsonRequest = checkoutCreateOrderRequest.ToJson();
            return _orders.Request<CheckoutCreateOrderResponse>(jsonRequest);
        }

        /// <summary>
        /// POST /orders API call async
        /// </summary>
        /// <param name="checkoutCreateOrderRequest"></param>
        /// <returns>CheckoutCreateOrderResponse</returns>
        public async Task<CheckoutCreateOrderResponse> OrdersAsync(CheckoutCreateOrderRequest checkoutCreateOrderRequest)
        {
            var jsonRequest = checkoutCreateOrderRequest.ToJson();
            return await _orders.RequestAsync<CheckoutCreateOrderResponse>(jsonRequest);
        }

        /// <summary>
        /// POST /ordersCancel API call sync
        /// </summary>
        /// <param name="checkoutCancelOrderRequest"></param>
        /// <returns>CheckoutCancelOrderResponse</returns>
        public CheckoutCancelOrderResponse OrdersCancel(CheckoutCancelOrderRequest checkoutCancelOrderRequest)
        {
            var jsonRequest = checkoutCancelOrderRequest.ToJson();
            return _ordersCancel.Request<CheckoutCancelOrderResponse>(jsonRequest);
        }

        /// <summary>
        /// POST /ordersCancel API call async
        /// </summary>
        /// <param name="checkoutCancelOrderRequest"></param>
        /// <returns>CheckoutCancelOrderResponse</returns>
        public async Task<CheckoutCancelOrderResponse> OrdersCancelAsync(CheckoutCancelOrderRequest checkoutCancelOrderRequest)
        {
            var jsonRequest = checkoutCancelOrderRequest.ToJson();
            return await _ordersCancel.RequestAsync<CheckoutCancelOrderResponse>(jsonRequest);
        }

        /// <summary>
        /// POST /{paymentPspReference}/cancel API call sync
        /// </summary>
        /// <param name="paymentPspReference"></param>
        /// <param name="createPaymentCancelRequest"></param>
        /// <returns>PaymentCancelResource</returns>
        public PaymentCancelResource PaymentsCancels(string paymentPspReference, CreatePaymentCancelRequest createPaymentCancelRequest)
        {
            var paymentsCancels = new PaymentsCancels(this, paymentPspReference);
            var jsonRequest = createPaymentCancelRequest.ToJson();
            return paymentsCancels.Request<PaymentCancelResource>(jsonRequest);
        }

        /// <summary>
        /// POST /{paymentPspReference}/cancel API call async
        /// </summary>
        /// <param name="paymentPspReference"></param>
        /// <param name="createPaymentCancelRequest"></param>
        /// <returns>PaymentCancelResource</returns>
        public async Task<PaymentCancelResource> PaymentsCancelsAsync(string paymentPspReference, CreatePaymentCancelRequest createPaymentCancelRequest)
        {
            var paymentsCancels = new PaymentsCancels(this, paymentPspReference);
            var jsonRequest = Util.JsonOperation.SerializeRequest(createPaymentCancelRequest);
            return await paymentsCancels.RequestAsync<PaymentCancelResource>(jsonRequest);
        }

        /// <summary>
        /// POST /{paymentPspReference}/cancel API call sync
        /// </summary>
        /// <param name="paymentPspReference"></param>
        /// <param name="createPaymentCaptureRequest"></param>
        /// <returns>PaymentCancelResource</returns>
        public PaymentCaptureResource PaymentsCaptures(string paymentPspReference, CreatePaymentCaptureRequest createPaymentCaptureRequest)
        {
            var paymentsCapture = new PaymentsCapture(this, paymentPspReference);
            var jsonRequest = createPaymentCaptureRequest.ToJson();
            return paymentsCapture.Request<PaymentCaptureResource>(jsonRequest);
        }

        /// <summary>
        /// POST /{paymentPspReference}/capture API call async
        /// </summary>
        /// <param name="paymentPspReference"></param>
        /// <param name="createPaymentCaptureRequest"></param>
        /// <returns>PaymentCaptureResource</returns>
        public async Task<PaymentCaptureResource> PaymentsCapturesAsync(string paymentPspReference, CreatePaymentCaptureRequest createPaymentCaptureRequest)
        {
            var paymentsCapture = new PaymentsCapture(this, paymentPspReference);
            var jsonRequest = createPaymentCaptureRequest.ToJson();
            return await paymentsCapture.RequestAsync<PaymentCaptureResource>(jsonRequest);
        }
        
        /// <summary>
        /// POST /{paymentPspReference}/refund API call sync
        /// </summary>
        /// <param name="paymentPspReference"></param>
        /// <param name="createPaymentRefundRequest"></param>
        /// <returns>PaymentRefundResource</returns>
        public PaymentRefundResource PaymentsRefunds(string paymentPspReference, CreatePaymentRefundRequest createPaymentRefundRequest)
        {
            var paymentsRefunds = new PaymentsRefunds(this, paymentPspReference);
            var jsonRequest = createPaymentRefundRequest.ToJson();
            return paymentsRefunds.Request<PaymentRefundResource>(jsonRequest);
        }

        /// <summary>
        /// POST /{paymentPspReference}/refund API call async
        /// </summary>
        /// <param name="paymentPspReference"></param>
        /// <param name="createPaymentRefundRequest"></param>
        /// <returns>PaymentRefundResource</returns>
        public async Task<PaymentRefundResource> PaymentsRefundsAsync(string paymentPspReference, CreatePaymentRefundRequest createPaymentRefundRequest)
        {
            var paymentsRefunds = new PaymentsRefunds(this, paymentPspReference);
            var jsonRequest = createPaymentRefundRequest.ToJson();
            return await paymentsRefunds.RequestAsync<PaymentRefundResource>(jsonRequest);
        }
        
        /// <summary>
        /// POST /{paymentPspReference}/reversal API call sync
        /// </summary>
        /// <param name="paymentPspReference"></param>
        /// <param name="createPaymentReversalRequest"></param>
        /// <returns>PaymentReversalResource</returns>
        public PaymentReversalResource PaymentsReversals(string paymentPspReference, CreatePaymentReversalRequest createPaymentReversalRequest)
        {
            var paymentReversal = new PaymentsReversals(this, paymentPspReference);
            var jsonRequest = createPaymentReversalRequest.ToJson();
            return paymentReversal.Request<PaymentReversalResource>(jsonRequest);
        }

        /// <summary>
        /// POST /{paymentPspReference}/reversal API call async
        /// </summary>
        /// <param name="paymentPspReference"></param>
        /// <param name="createPaymentReversalRequest"></param>
        /// <returns>PaymentReversalResource</returns>
        public async Task<PaymentReversalResource> PaymentsReversalsAsync(string paymentPspReference, CreatePaymentReversalRequest createPaymentReversalRequest)
        {
            var paymentReversal = new PaymentsReversals(this, paymentPspReference);
            var jsonRequest = createPaymentReversalRequest.ToJson();
            return await paymentReversal.RequestAsync<PaymentReversalResource>(jsonRequest);
        }
        
        /// <summary>
        /// POST /{paymentPspReference}/amountUpdates API call sync
        /// </summary>
        /// <param name="paymentPspReference"></param>
        /// <param name="createPaymentAmountUpdateRequest"></param>
        /// <returns>PaymentAmountUpdateResource</returns>
       public PaymentAmountUpdateResource PaymentsAmountUpdates(string paymentPspReference, CreatePaymentAmountUpdateRequest createPaymentAmountUpdateRequest)
        {
            var paymentsAmountUpdates = new PaymentsAmountUpdates(this, paymentPspReference); 
            var jsonRequest = createPaymentAmountUpdateRequest.ToJson();
            return paymentsAmountUpdates.Request<PaymentAmountUpdateResource>(jsonRequest);
        }

        /// <summary>
        /// POST /{paymentPspReference}/amountUpdates API call async
        /// </summary>
        /// <param name="paymentPspReference"></param>
        /// <param name="createPaymentAmountUpdateRequest"></param>
        /// <returns>PaymentAmountUpdateResource</returns>
        public async Task<PaymentAmountUpdateResource> PaymentsAmountUpdatesAsync(string paymentPspReference, CreatePaymentAmountUpdateRequest createPaymentAmountUpdateRequest)
        {
            var paymentsAmountUpdates = new PaymentsAmountUpdates(this, paymentPspReference);      
            var jsonRequest = createPaymentAmountUpdateRequest.ToJson();
            return await paymentsAmountUpdates.RequestAsync<PaymentAmountUpdateResource>(jsonRequest);
        }
        
        /// <summary>
        /// POST /cancels API call sync
        /// </summary>
        /// <param name="createStandalonePaymentCancelRequest"></param>
        /// <returns>StandalonePaymentCancelResource</returns>
        public StandalonePaymentCancelResource Cancels(CreateStandalonePaymentCancelRequest createStandalonePaymentCancelRequest)
        {
            var jsonRequest = createStandalonePaymentCancelRequest.ToJson();
            return _cancels.Request<StandalonePaymentCancelResource>(jsonRequest);
        }

        /// <summary>
        /// POST /cancels API call async
        /// </summary>
        /// <param name="createStandalonePaymentCancelRequest"></param>
        /// <returns>StandalonePaymentCancelResource</returns>
        public async Task<StandalonePaymentCancelResource> CancelsAsync( CreateStandalonePaymentCancelRequest createStandalonePaymentCancelRequest)
        {
            var jsonRequest = createStandalonePaymentCancelRequest.ToJson();
            return await _cancels.RequestAsync<StandalonePaymentCancelResource>(jsonRequest);
        }

        /// <summary>
        /// POST /donations API call sync
        /// </summary>
        /// <param name="paymentDonationRequest"></param>
        /// <returns>StandalonePaymentCancelResource</returns>
        public DonationResponse Donations(PaymentDonationRequest paymentDonationRequest)
        {
            var jsonRequest = paymentDonationRequest.ToJson();
            return _donations.Request<DonationResponse>(jsonRequest);
        }

        /// <summary>
        /// POST /donations API call async
        /// </summary>
        /// <param name="paymentDonationRequest"></param>
        /// <returns>StandalonePaymentCancelResource</returns>
        public async Task<DonationResponse> DonationsAsync( PaymentDonationRequest paymentDonationRequest)
        {
            var jsonRequest = paymentDonationRequest.ToJson();
            return await _donations.RequestAsync<DonationResponse>(jsonRequest);
        }
        
        /// <summary>
        /// POST /cardDetails API call sync
        /// </summary>
        /// <param name="cardDetailsRequest"></param>
        /// <returns>CardDetailsResponse</returns>
        public CardDetailsResponse CardDetails(CardDetailsRequest cardDetailsRequest)
        {
            var jsonRequest = cardDetailsRequest.ToJson();
            return _cardDetails.Request<CardDetailsResponse>(jsonRequest);
        }
        
        /// <summary>
        /// POST /cardDetails API call async
        /// </summary>
        /// <param name="cardDetailsRequest"></param>
        /// <returns>CardDetailsResponse</returns>
        public async Task<CardDetailsResponse> CardDetailsAsync(CardDetailsRequest cardDetailsRequest)
        {
            var jsonRequest = cardDetailsRequest.ToJson();
            return await _cardDetails.RequestAsync<CardDetailsResponse>(jsonRequest);
        }

        /// <summary>
        /// POST /cardDetails API call async
        /// </summary>
        /// <param name="createApplePaySessionRequest"></param>
        /// <returns>CardDetailsResponse</returns>
        public async Task<ApplePaySessionResponse> ApplePaySessionsAsync(CreateApplePaySessionRequest createApplePaySessionRequest)
        {
            var jsonRequest = createApplePaySessionRequest.ToJson();
            return await _applePaySessions.RequestAsync<ApplePaySessionResponse>(jsonRequest);
        }
        
        /// <summary>
        /// POST /cardDetails API call sync
        /// </summary>
        /// <param name="createApplePaySessionRequest"></param>
        /// <returns>CardDetailsResponse</returns>
        public ApplePaySessionResponse ApplePaySessions(CreateApplePaySessionRequest createApplePaySessionRequest)
        {
            return ApplePaySessionsAsync(createApplePaySessionRequest).GetAwaiter().GetResult();
        }
    }
}
