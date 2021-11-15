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
 * Copyright (c) 2021 Adyen B.V.
 * This file is open source and available under the MIT license.
 * See the LICENSE file for more info.
 */
#endregion

using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Model.ApplicationInformation;
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
        private OrdersCancel _ordersCancel;
        private PaymentMethodsBalance _paymentMethodsBalance;
       
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
            _ordersCancel = new OrdersCancel(this);
            _paymentMethodsBalance = new PaymentMethodsBalance(this);
        }

        /// <summary>
        /// Post /payments API call
        /// </summary>
        /// <param name="paymentRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public PaymentResponse Payments(PaymentRequest paymentRequest, RequestOptions requestOptions = null)
        {
            //if it is set by the merchant do not override
            if (paymentRequest.ApplicationInfo == null)
            {
                paymentRequest.ApplicationInfo = new ApplicationInfo();

            }
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
            //if it is set by the merchant do not override
            if (paymentRequest.ApplicationInfo == null)
            {
                paymentRequest.ApplicationInfo = new ApplicationInfo();

            }
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
            //if it is set by the merchant do not override
            if (paymentSessionRequest.ApplicationInfo == null)
            {
                paymentSessionRequest.ApplicationInfo = new ApplicationInfo();

            }
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
            //if it is set by the merchant do not override
            if (paymentSessionRequest.ApplicationInfo == null)
            {
                paymentSessionRequest.ApplicationInfo = new ApplicationInfo();

            }
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
        /// POST /paymentMethods/balance API call sync
        /// </summary>
        /// <param name="CheckoutBalanceCheckRequest"></param>
        /// <returns>CheckoutBalanceCheckResponse</returns>
        public CheckoutBalanceCheckResponse PaymentMethodsBalance(CheckoutBalanceCheckRequest checkoutBalanceCheckRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(checkoutBalanceCheckRequest);
            var jsonResponse = _paymentMethodsBalance.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CheckoutBalanceCheckResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentMethods/balance API call async
        /// </summary>
        /// <param name="CheckoutBalanceCheckRequest"></param>
        /// <returns>CheckoutBalanceCheckResponse</returns>
        public async Task<CheckoutBalanceCheckResponse> PaymentMethodsBalanceAsync(CheckoutBalanceCheckRequest checkoutBalanceCheckRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(checkoutBalanceCheckRequest);
            var jsonResponse = await _paymentMethodsBalance.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CheckoutBalanceCheckResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /orders API call sync
        /// </summary>
        /// <param name="CheckoutCreateOrderRequest"></param>
        /// <returns>CheckoutCreateOrderResponse</returns>
        public CheckoutCreateOrderResponse Orders(CheckoutCreateOrderRequest checkoutCreateOrderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(checkoutCreateOrderRequest);
            var jsonResponse = _orders.Request(jsonRequest);
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

        /// <summary>
        /// POST /ordersCancel API call sync
        /// </summary>
        /// <param name="CheckoutCancelOrderRequest"></param>
        /// <returns>CheckoutCancelOrderResponse</returns>
        public CheckoutCancelOrderResponse OrdersCancel(CheckoutCancelOrderRequest checkoutCancelOrderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(checkoutCancelOrderRequest);
            var jsonResponse = _ordersCancel.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CheckoutCancelOrderResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /ordersCancel API call async
        /// </summary>
        /// <param name="CheckoutCancelOrderRequest"></param>
        /// <returns>CheckoutCancelOrderResponse</returns>
        public async Task<CheckoutCancelOrderResponse> OrdersCancelAsync(CheckoutCancelOrderRequest checkoutCancelOrderRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(checkoutCancelOrderRequest);
            var jsonResponse = await _ordersCancel.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<CheckoutCancelOrderResponse>(jsonResponse);
        }
    }
}
