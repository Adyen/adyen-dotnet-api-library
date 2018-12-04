using System;
using System.Collections.Generic;
using System.Text;
using Adyen.EcommLibrary.Model.Checkout;
using Adyen.EcommLibrary.Service.Resource.Checkout;
using Newtonsoft.Json;

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

        public PaymentResponse Payments(PaymentRequest paymentRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentRequest);
            var jsonResponse = _payments.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentResponse>(jsonResponse);
        }

        public PaymentMethodsResponse PaymentMethods(PaymentMethodsRequest paymentMethodsRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentMethodsRequest);
            var jsonResponse = _paymentMethods.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentMethodsResponse>(jsonResponse);
        }

        public PaymentResponse PaymentDetails(DetailsRequest detailsRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(detailsRequest);
            var jsonResponse = _paymentDetails.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentResponse>(jsonResponse);
        }

        public PaymentSetupResponse PaymentSession(PaymentSetupRequest paymentSetupRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentSetupRequest);
            var jsonResponse = _paymentSession.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentSetupResponse>(jsonResponse);
        }

        public PaymentVerificationResponse PaymentsResult(PaymentVerificationRequest paymentVerificationRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentVerificationRequest);
            var jsonResponse = _paymentsResult.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentVerificationResponse>(jsonResponse);
        }
    }
}
