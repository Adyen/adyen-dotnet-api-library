using Adyen.EcommLibrary.Model;
using Adyen.EcommLibrary.Service.Resource.Payment;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Adyen.EcommLibrary.Service
{
    public class Payment : AbstractService
    {
        private Authorise _authorise;
        private Authorise3D _authorise3D;

        public Payment(Client client)
            : base(client)
        {
            _authorise = new Authorise(this);
            _authorise3D = new Authorise3D(this);
        }

        public PaymentResult Authorise(PaymentRequest paymentRequest)
        {
            PaymentResult paymentResult = null;
            try
            {
                var jsonRequest = Util.JsonOperation.SerializeRequest(paymentRequest);
                var jsonResponse = _authorise.Request(jsonRequest);
                paymentResult = JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return paymentResult;
        }

        public async Task<PaymentResult> AuthoriseAsync(PaymentRequest paymentRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentRequest);
            var jsonResponse = await _authorise.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }


        public PaymentResult Authorise3D(PaymentRequest3D paymentRequest3D)
        {
            PaymentResult paymentResult = null;
            try
            {
                var jsonRequest = JsonConvert.SerializeObject(paymentRequest3D);

                var jsonResponse = _authorise3D.Request(jsonRequest);
                paymentResult = JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return paymentResult;
        }
    }
}
