using Adyen.EcommLibrary.Model;
using Adyen.EcommLibrary.Service.Resource.Payment;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Adyen.EcommLibrary.Service
{
    public class Payment : AbstractService
    {
        private readonly Authorise _authorise;
        private readonly Authorise3D _authorise3D;
        private readonly AuthoriseThreeDSecure2 _authoriseThreeDSecure2;

        public Payment(Client client)
            : base(client)
        {
            _authorise = new Authorise(this);
            _authorise3D = new Authorise3D(this);
            _authoriseThreeDSecure2 = new AuthoriseThreeDSecure2(this);
        }

        public PaymentResult Authorise(PaymentRequest paymentRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentRequest);
            var jsonResponse = _authorise.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public async Task<PaymentResult> AuthoriseAsync(PaymentRequest paymentRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentRequest);
            var jsonResponse = await _authorise.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public PaymentResult Authorise3D(PaymentRequest3D paymentRequest3D)
        {
            var jsonRequest = JsonConvert.SerializeObject(paymentRequest3D);
            var jsonResponse = _authorise3D.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public async Task<PaymentResult> AuthoriseAsync(PaymentRequestThreeDSecure2 paymentRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(paymentRequest);
            var jsonResponse = await _authorise.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public PaymentResult AuthoriseThreeDSecure2(PaymentRequestThreeDSecure2 paymentRequest)
        {
            var jsonRequest = JsonConvert.SerializeObject(paymentRequest);
            var jsonResponse = _authoriseThreeDSecure2.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }

        public async Task<PaymentResult> AuthoriseThreeDSecure2Async(PaymentRequestThreeDSecure2 paymentRequest)
        {
            var jsonRequest = JsonConvert.SerializeObject(paymentRequest);
            var jsonResponse = await _authoriseThreeDSecure2.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<PaymentResult>(jsonResponse);
        }


    }
}
