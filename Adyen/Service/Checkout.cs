#region License
// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2020 Adyen B.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */
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

        public Checkout(Client client) : base(client)
        {
            IsApiKeyRequired = true;
            _payments = new Payments(this);
            _paymentMethods = new PaymentMethods(this);
            _paymentDetails = new PaymentDetails(this);
            _paymentSession = new PaymentSession(this);
            _paymentsResult = new PaymentsResult(this);
            _paymentLinksResult = new PaymentLinks(this);
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
        public PaymentResponse PaymentDetails(PaymentsDetailsRequest paymentsDetailsRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentsDetailsRequest);
            var jsonResponse = _paymentDetails.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentResponse>(jsonResponse);
        }

        /// <summary>
        ///  POST payments/details API call async
        /// </summary>
        /// <param name="paymentsDetailsRequest"></param>
        /// <returns>PaymentsResponse</returns>
        public async Task<PaymentResponse> PaymentDetailsAsync(PaymentsDetailsRequest paymentsDetailsRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentsDetailsRequest);
            var jsonResponse = await _paymentDetails.RequestAsync(jsonRequest, requestOptions);
            return Util.JsonOperation.Deserialize<PaymentResponse>(jsonResponse);
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
            return Util.JsonOperation.Deserialize<PaymentResultResponse>(jsonResponse);
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
    }
}