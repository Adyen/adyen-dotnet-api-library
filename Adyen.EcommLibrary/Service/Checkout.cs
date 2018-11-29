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

        public Checkout(Client client) : base(client)
        {
            _payments = new Payments(this);
            _paymentMethods = new PaymentMethods(this);
            _paymentDetails = new PaymentDetails(this);
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
    }
}
