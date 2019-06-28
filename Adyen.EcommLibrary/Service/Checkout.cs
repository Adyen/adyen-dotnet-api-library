using System;
using System.Collections.Generic;
using System.Text;
using Adyen.EcommLibrary.Model;
using Adyen.EcommLibrary.Model.Checkout;
using Adyen.EcommLibrary.Service.Resource.Checkout;
using Newtonsoft.Json;
using PaymentRequest = Adyen.EcommLibrary.Model.Checkout.PaymentRequest;

namespace Adyen.EcommLibrary.Service
{
    public class Checkout : AbstractService
    {
        private Payments _payments;
        private PaymentMethods _paymentMethods;
        private PaymentDetails _paymentDetails;
        private PaymentSession _paymentSession;
        private PaymentsResult _paymentsResult;

        public Checkout(Client client) : base(client)
        {
             IsApiKeyRequired = true;
            _payments = new Payments(this);
            _paymentMethods = new PaymentMethods(this);
            _paymentDetails = new PaymentDetails(this);
            _paymentSession = new PaymentSession(this);
            _paymentsResult = new PaymentsResult(this);
        }

        /// <summary>
        /// Post /payments API call
        /// </summary>
        /// <param name="paymentRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns></returns>
        public PaymentsResponse Payments(PaymentRequest paymentRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentRequest);
            var jsonResponse = _payments.Request(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PaymentsResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentMethods API call
        /// </summary>
        /// <param name="paymentMethodsRequest"></param>
        /// <returns></returns>
        public PaymentMethodsResponse PaymentMethods(PaymentMethodsRequest paymentMethodsRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentMethodsRequest);
            var jsonResponse = _paymentMethods.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentMethodsResponse>(jsonResponse);
        }

        /// <summary>
        ///  POST payments/details API call
        /// </summary>
        /// <param name="paymentsDetailsRequest"></param>
        /// <returns></returns>
        public PaymentsResponse PaymentDetails(PaymentsDetailsRequest paymentsDetailsRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentsDetailsRequest);
            var jsonResponse = _paymentDetails.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentsResponse>(jsonResponse);
        }

        /// <summary>
        /// POST /paymentSession API call
        /// </summary>
        /// <param name="paymentSessionRequest"></param>
        /// <returns></returns>
        public PaymentSessionResponse PaymentSession(PaymentSessionRequest paymentSessionRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentSessionRequest);
            var jsonResponse = _paymentSession.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentSessionResponse>(jsonResponse);
        }

        /// <summary>
        /// POST payments/result API call
        /// </summary>
        /// <param name="paymentResultRequest"></param>
        /// <returns></returns>
        public PaymentResultResponse PaymentsResult(PaymentResultRequest paymentResultRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentResultRequest);
            var jsonResponse = _paymentsResult.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentResultResponse>(jsonResponse);
        }
    }
}
