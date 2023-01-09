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
using Newtonsoft.Json;
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
            var jsonResponse = _payments.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResponse>(jsonResponse);
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
            var jsonResponse = await _payments.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentMethods API call
        /// </summary>
        /// <param name="paymentMethodsRequest"></param>
        /// <returns>PaymentMethodsResponse</returns>
        public PaymentMethodsResponse PaymentMethods(PaymentMethodsRequest paymentMethodsRequest)
        {
            var jsonRequest = paymentMethodsRequest.ToJson();
            var jsonResponse = _paymentMethods.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentMethodsResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentMethods API call async
        /// </summary>
        /// <param name="paymentMethodsRequest"></param>
        /// <returns>PaymentMethodsResponse</returns>
        public async Task<PaymentMethodsResponse> PaymentMethodsAsync(PaymentMethodsRequest paymentMethodsRequest)
        {
            var jsonRequest = paymentMethodsRequest.ToJson();
            var jsonResponse = await _paymentMethods.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentMethodsResponse>(jsonResponse);
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
            var jsonResponse = _paymentDetails.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentDetailsResponse>(jsonResponse);
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
            var jsonResponse = await _paymentDetails.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentDetailsResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentSession API call
        /// </summary>
        /// <param name="paymentSetupRequest"></param>
        /// <returns>PaymentSessionResponse</returns>
        public PaymentSetupResponse PaymentSession(PaymentSetupRequest paymentSetupRequest)
        {
            var jsonRequest = paymentSetupRequest.ToJson();
            var jsonResponse = _paymentSession.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentSetupResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentSession API call async
        /// </summary>
        /// <param name="paymentSetupRequest"></param>
        /// <returns>PaymentSetupResponse</returns>
        public async Task<PaymentSetupResponse> PaymentSessionAsync(PaymentSetupRequest paymentSetupRequest)
        {
            var jsonRequest = paymentSetupRequest.ToJson();
            var jsonResponse = await _paymentSession.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentSetupResponse>(jsonResponse);
        }

        /// <summary>
        /// POST payments/result API call
        /// </summary>
        /// <param name="paymentVerificationRequest"></param>
        /// <returns>PaymentVerificationResponse</returns>
        public PaymentVerificationResponse PaymentsResult(PaymentVerificationRequest paymentVerificationRequest)
        {
            var jsonRequest = paymentVerificationRequest.ToJson();
            var jsonResponse = _paymentsResult.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentVerificationResponse>(jsonResponse);
        }

        /// <summary>
        /// POST payments/result API call async
        /// </summary>
        /// <param name="paymentVerificationRequest"></param>
        /// <returns>PaymentVerificationResponse</returns>
        public async Task<PaymentVerificationResponse> PaymentsResultAsync(PaymentVerificationRequest paymentVerificationRequest)
        {
            var jsonRequest = paymentVerificationRequest.ToJson();
            var jsonResponse = await _paymentsResult.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentVerificationResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentsLinks API call 
        /// </summary>
        /// <param name="createPaymentLinkRequest"></param>
        /// <returns>PaymentLinkResponse</returns>
        public PaymentLinkResponse PaymentLinks(CreatePaymentLinkRequest createPaymentLinkRequest)
        {
            var jsonRequest = createPaymentLinkRequest.ToJson();
            var jsonResponse = _paymentLinksResult.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentLinkResponse>(jsonResponse);
        }
        
        /// <summary>
        /// POST /paymentsLinks API call async
        /// </summary>
        /// <param name="createPaymentLinkRequest"></param>
        /// <returns>PaymentLinkResponse</returns>
        public async Task<PaymentLinkResponse> PaymentLinksAsync(CreatePaymentLinkRequest createPaymentLinkRequest)
        {
            var jsonRequest = createPaymentLinkRequest.ToJson();
            var jsonResponse = await _paymentLinksResult.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentLinkResponse>(jsonResponse);
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
            var jsonResponse = paymentLinks.Request(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<PaymentLinkResponse>(jsonResponse);
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
            var jsonResponse = await paymentLinks.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<PaymentLinkResponse>(jsonResponse);
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
            var jsonResponse = paymentLinks.Request(jsonRequest, null, patch);
            return JsonConvert.DeserializeObject<PaymentLinkResponse>(jsonResponse);
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
            var jsonResponse = await paymentLinks.RequestAsync(jsonRequest, null, patch);
            return JsonConvert.DeserializeObject<PaymentLinkResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /sessions API call 
        /// </summary>
        /// <param name="createCheckoutSessionRequest"></param>
        /// <returns>CreateCheckoutSessionResponse</returns>
        public CreateCheckoutSessionResponse Sessions(CreateCheckoutSessionRequest createCheckoutSessionRequest)
        {
            var jsonRequest = createCheckoutSessionRequest.ToJson();
            var jsonResponse =_sessions.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CreateCheckoutSessionResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /sessions API call async
        /// </summary>
        /// <param name="createCheckoutSessionRequest"></param>
        /// <returns>CreateCheckoutSessionResponse</returns>
        public async Task<CreateCheckoutSessionResponse> SessionsAsync(CreateCheckoutSessionRequest createCheckoutSessionRequest)
        {
            var jsonRequest = createCheckoutSessionRequest.ToJson();
            var jsonResponse = await _sessions.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CreateCheckoutSessionResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentMethods/balance API call sync
        /// </summary>
        /// <param name="checkoutBalanceCheckRequest"></param>
        /// <returns>CheckoutBalanceCheckResponse</returns>
        public CheckoutBalanceCheckResponse PaymentMethodsBalance(CheckoutBalanceCheckRequest checkoutBalanceCheckRequest)
        {
            var jsonRequest = checkoutBalanceCheckRequest.ToJson();
            var jsonResponse = _paymentMethodsBalance.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CheckoutBalanceCheckResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentMethods/balance API call async
        /// </summary>
        /// <param name="checkoutBalanceCheckRequest"></param>
        /// <returns>CheckoutBalanceCheckResponse</returns>
        public async Task<CheckoutBalanceCheckResponse> PaymentMethodsBalanceAsync(CheckoutBalanceCheckRequest checkoutBalanceCheckRequest)
        {
            var jsonRequest = checkoutBalanceCheckRequest.ToJson();
            var jsonResponse = await _paymentMethodsBalance.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CheckoutBalanceCheckResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /orders API call sync
        /// </summary>
        /// <param name="checkoutCreateOrderRequest"></param>
        /// <returns>CheckoutCreateOrderResponse</returns>
        public CheckoutCreateOrderResponse Orders(CheckoutCreateOrderRequest checkoutCreateOrderRequest)
        {
            var jsonRequest = checkoutCreateOrderRequest.ToJson();
            var jsonResponse = _orders.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CheckoutCreateOrderResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /orders API call async
        /// </summary>
        /// <param name="checkoutCreateOrderRequest"></param>
        /// <returns>CheckoutCreateOrderResponse</returns>
        public async Task<CheckoutCreateOrderResponse> OrdersAsync(CheckoutCreateOrderRequest checkoutCreateOrderRequest)
        {
            var jsonRequest = checkoutCreateOrderRequest.ToJson();
            var jsonResponse = await _orders.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CheckoutCreateOrderResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /ordersCancel API call sync
        /// </summary>
        /// <param name="checkoutCancelOrderRequest"></param>
        /// <returns>CheckoutCancelOrderResponse</returns>
        public CheckoutCancelOrderResponse OrdersCancel(CheckoutCancelOrderRequest checkoutCancelOrderRequest)
        {
            var jsonRequest = checkoutCancelOrderRequest.ToJson();
            var jsonResponse = _ordersCancel.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CheckoutCancelOrderResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /ordersCancel API call async
        /// </summary>
        /// <param name="checkoutCancelOrderRequest"></param>
        /// <returns>CheckoutCancelOrderResponse</returns>
        public async Task<CheckoutCancelOrderResponse> OrdersCancelAsync(CheckoutCancelOrderRequest checkoutCancelOrderRequest)
        {
            var jsonRequest = checkoutCancelOrderRequest.ToJson();
            var jsonResponse = await _ordersCancel.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CheckoutCancelOrderResponse>(jsonResponse);
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
            var jsonResponse = paymentsCancels.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentCancelResource>(jsonResponse);
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
            var jsonResponse = await paymentsCancels.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentCancelResource>(jsonResponse);
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
            var jsonResponse = paymentsCapture.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentCaptureResource>(jsonResponse);
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
            var jsonResponse = await paymentsCapture.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentCaptureResource>(jsonResponse);
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
            var jsonResponse = paymentsRefunds.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentRefundResource>(jsonResponse);
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
            var jsonResponse = await paymentsRefunds.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentRefundResource>(jsonResponse);
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
            var jsonResponse = paymentReversal.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentReversalResource>(jsonResponse);
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
            var jsonResponse = await paymentReversal.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentReversalResource>(jsonResponse);
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
            var jsonResponse = paymentsAmountUpdates.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentAmountUpdateResource>(jsonResponse);
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
            var jsonResponse = await paymentsAmountUpdates.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentAmountUpdateResource>(jsonResponse);
        }
        
        /// <summary>
        /// POST /cancels API call sync
        /// </summary>
        /// <param name="createStandalonePaymentCancelRequest"></param>
        /// <returns>StandalonePaymentCancelResource</returns>
        public StandalonePaymentCancelResource Cancels(CreateStandalonePaymentCancelRequest createStandalonePaymentCancelRequest)
        {
            var jsonRequest = createStandalonePaymentCancelRequest.ToJson();
            var jsonResponse = _cancels.Request(jsonRequest);
            return JsonConvert.DeserializeObject<StandalonePaymentCancelResource>(jsonResponse);
        }

        /// <summary>
        /// POST /cancels API call async
        /// </summary>
        /// <param name="createStandalonePaymentCancelRequest"></param>
        /// <returns>StandalonePaymentCancelResource</returns>
        public async Task<StandalonePaymentCancelResource> CancelsAsync( CreateStandalonePaymentCancelRequest createStandalonePaymentCancelRequest)
        {
            var jsonRequest = createStandalonePaymentCancelRequest.ToJson();
            var jsonResponse = await _cancels.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<StandalonePaymentCancelResource>(jsonResponse);
        }

        /// <summary>
        /// POST /donations API call sync
        /// </summary>
        /// <param name="paymentDonationRequest"></param>
        /// <returns>StandalonePaymentCancelResource</returns>
        public DonationResponse Donations(PaymentDonationRequest paymentDonationRequest)
        {
            var jsonRequest = paymentDonationRequest.ToJson();
            var jsonResponse = _donations.Request(jsonRequest);
            return JsonConvert.DeserializeObject<DonationResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /donations API call async
        /// </summary>
        /// <param name="paymentDonationRequest"></param>
        /// <returns>StandalonePaymentCancelResource</returns>
        public async Task<DonationResponse> DonationsAsync( PaymentDonationRequest paymentDonationRequest)
        {
            var jsonRequest = paymentDonationRequest.ToJson();
            var jsonResponse = await _donations.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<DonationResponse>(jsonResponse);
        }
        
        /// <summary>
        /// POST /cardDetails API call sync
        /// </summary>
        /// <param name="cardDetailsRequest"></param>
        /// <returns>CardDetailsResponse</returns>
        public CardDetailsResponse CardDetails(CardDetailsRequest cardDetailsRequest)
        {
            var jsonRequest = cardDetailsRequest.ToJson();
            var jsonResponse = _cardDetails.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CardDetailsResponse>(jsonResponse);
        }
        
        /// <summary>
        /// POST /cardDetails API call async
        /// </summary>
        /// <param name="cardDetailsRequest"></param>
        /// <returns>CardDetailsResponse</returns>
        public async Task<CardDetailsResponse> CardDetailsAsync(CardDetailsRequest cardDetailsRequest)
        {
            var jsonRequest = cardDetailsRequest.ToJson();
            var jsonResponse = await _cardDetails.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CardDetailsResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /cardDetails API call async
        /// </summary>
        /// <param name="createApplePaySessionRequest"></param>
        /// <returns>CardDetailsResponse</returns>
        public async Task<ApplePaySessionResponse> ApplePaySessionsAsync(CreateApplePaySessionRequest createApplePaySessionRequest)
        {
            var jsonRequest = createApplePaySessionRequest.ToJson();
            var jsonResult = await _applePaySessions.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<ApplePaySessionResponse>(jsonResult);
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
