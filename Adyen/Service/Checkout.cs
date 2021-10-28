﻿#region License
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
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion

using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Model.Checkout;
using Adyen.Service.Resource.Checkout;
using Newtonsoft.Json;
using PaymentDetails = Adyen.Service.Resource.Checkout.PaymentDetails;
using PaymentRequest = Adyen.Model.Checkout.PaymentRequest;

namespace Adyen.Service
{
    public class Checkout : AbstractService
    {
        private Payments _payments;
        private PaymentMethods _paymentMethods;
        private PaymentDetails _paymentDetails;
        private PaymentSession _paymentSession;
        private PaymentsResult _paymentsResult;
        private PaymentLinks _paymentLinksResult;
        private Sessions _sessions;
        private Orders _orders;

        public Checkout(Client client) : base(client)
        {
            IsApiKeyRequired = true;
            _payments = new Payments(this);
            _paymentMethods = new PaymentMethods(this);
            _paymentDetails = new PaymentDetails(this);
            _paymentSession = new PaymentSession(this);
            _paymentsResult = new PaymentsResult(this);
            _paymentLinksResult = new PaymentLinks(this);
            _sessions = new Sessions(this);
            _orders = new Orders(this);
        }

        /// <summary>
        /// Post /payments API call
        /// </summary>
        /// <param name="paymentRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public PaymentResponse Payments(PaymentRequest paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentRequest);
            var jsonResponse = _payments.Request(jsonRequest, requestOptions);
            return Util.JsonOperation.Deserialize<PaymentResponse>(jsonResponse);
        }

        /// <summary>
        /// Post /payments API call async
        /// </summary>
        /// <param name="paymentRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public async Task<PaymentResponse> PaymentsAsync(PaymentRequest paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentRequest);
            var jsonResponse = await _payments.RequestAsync(jsonRequest, requestOptions);
            return Util.JsonOperation.Deserialize<PaymentResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentMethods API call
        /// </summary>
        /// <param name="paymentMethodsRequest"></param>
        /// <returns>PaymentMethodsResponse</returns>
        public PaymentMethodsResponse PaymentMethods(PaymentMethodsRequest paymentMethodsRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentMethodsRequest);
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
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentMethodsRequest);
            var jsonResponse = await _paymentMethods.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentMethodsResponse>(jsonResponse);
        }

        /// <summary>
        ///  POST payments/details API call
        /// </summary>
        /// <param name="paymentsDetailsRequest"></param>
        /// <returns>PaymentsResponse</returns>
        public PaymentDetailsResponse PaymentDetails(PaymentsDetailsRequest paymentsDetailsRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentsDetailsRequest);
            var jsonResponse = _paymentDetails.Request(jsonRequest, requestOptions);
            return Util.JsonOperation.Deserialize<PaymentDetailsResponse>(jsonResponse);
        }

        /// <summary>
        ///  POST payments/details API call async
        /// </summary>
        /// <param name="paymentsDetailsRequest"></param>
        /// <returns>PaymentDetailsResponse</returns>
        public async Task<PaymentDetailsResponse> PaymentDetailsAsync(PaymentsDetailsRequest paymentsDetailsRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentsDetailsRequest);
            var jsonResponse = await _paymentDetails.RequestAsync(jsonRequest, requestOptions);
            return Util.JsonOperation.Deserialize<PaymentDetailsResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentSession API call
        /// </summary>
        /// <param name="paymentSessionRequest"></param>
        /// <returns>PaymentSessionResponse</returns>
        public PaymentSessionResponse PaymentSession(PaymentSessionRequest paymentSessionRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentSessionRequest);
            var jsonResponse = _paymentSession.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentSessionResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentSession API call async
        /// </summary>
        /// <param name="paymentSessionRequest"></param>
        /// <returns>PaymentSessionResponse</returns>
        public async Task<PaymentSessionResponse> PaymentSessionAsync(PaymentSessionRequest paymentSessionRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentSessionRequest);
            var jsonResponse = await _paymentSession.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentSessionResponse>(jsonResponse);
        }

        /// <summary>
        /// POST payments/result API call
        /// </summary>
        /// <param name="paymentResultRequest"></param>
        /// <returns>PaymentResultResponse</returns>
        public PaymentResultResponse PaymentsResult(PaymentResultRequest paymentResultRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentResultRequest);
            var jsonResponse = _paymentsResult.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentResultResponse>(jsonResponse);
        }

        /// <summary>
        /// POST payments/result API call async
        /// </summary>
        /// <param name="paymentResultRequest"></param>
        /// <returns>PaymentResultResponse</returns>
        public async Task<PaymentResultResponse> PaymentsResultAsync(PaymentResultRequest paymentResultRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentResultRequest);
            var jsonResponse = await _paymentsResult.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentResultResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentsLinks API call 
        /// </summary>
        /// <param name="createPaymentLinkRequest"></param>
        /// <returns>CreatePaymentLinkResponse</returns>
        public PaymentLinkResource PaymentLinks(CreatePaymentLinkRequest createPaymentLinkRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(createPaymentLinkRequest);
            var jsonResponse = _paymentLinksResult.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentLinkResource>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentsLinks API call async
        /// </summary>
        /// <param name="createPaymentLinkRequest"></param>
        /// <returns>PaymentLinkResource</returns>
        public async Task<PaymentLinkResource> PaymentLinksAsync(CreatePaymentLinkRequest createPaymentLinkRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(createPaymentLinkRequest);
            var jsonResponse = await _paymentLinksResult.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentLinkResource>(jsonResponse);
        }

        /// <summary>
        /// POST /sessions API call 
        /// </summary>
        /// <param name="createCheckoutSessionRequest"></param>
        /// <returns>CreateCheckoutSessionResponse</returns>
        public CreateCheckoutSessionResponse Sessions(CreateCheckoutSessionRequest createCheckoutSessionRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(createCheckoutSessionRequest);
            var jsonResponse =_sessions.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CreateCheckoutSessionResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /sessions API call async
        /// </summary>
        /// <param name="createPaymentLinkRequest"></param>
        /// <returns>CreateCheckoutSessionResponse</returns>
        public async Task<CreateCheckoutSessionResponse> SessionsAsync(CreateCheckoutSessionRequest createCheckoutSessionRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(createCheckoutSessionRequest);
            var jsonResponse = await _sessions.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CreateCheckoutSessionResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /orders API call sync
        /// </summary>
        /// <param name="CheckoutCreateOrderRequest"></param>
        /// <returns>CheckoutCreateOrderResponse</returns>
        public CheckoutCreateOrderResponse Orders(CheckoutCreateOrderRequest checkoutCreateOrderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(checkoutCreateOrderRequest);
            var jsonResponse = _sessions.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CheckoutCreateOrderResponse>(jsonResponse);

        }

        /// <summary>
        /// POST /orders API call async
        /// </summary>
        /// <param name="CheckoutCreateOrderRequest"></param>
        /// <returns>CheckoutCreateOrderResponse</returns>
        public async Task<CheckoutCreateOrderResponse> OrdersAsync(CheckoutCreateOrderRequest checkoutCreateOrderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(checkoutCreateOrderRequest);
            var jsonResponse = await _orders.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CheckoutCreateOrderResponse>(jsonResponse);
        }
    }
}
