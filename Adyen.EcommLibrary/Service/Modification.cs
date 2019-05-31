using Adyen.EcommLibrary.Model.Modification;
using Adyen.EcommLibrary.Service.Resource.Modification;

namespace Adyen.EcommLibrary.Service
{
    public class Modification : AbstractService
    {
        private readonly Capture _capture;
        private readonly CancelOrRefund _cancelOrRefund;
        private readonly Refund _refund;
        private readonly Cancel _cancel;

        public Modification(Client clinet)
            : base(clinet)
        {
            _capture = new Capture(this);
            _cancelOrRefund = new CancelOrRefund(this);
            _refund = new Refund(this);
            _cancel = new Cancel(this);
        }

        public ModificationResult Capture(CaptureRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _capture.Request(jsonRequest);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }

        public ModificationResult CancelOrRefund(CancelOrRefundRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _cancelOrRefund.Request(jsonRequest);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }

        public ModificationResult Refund(RefundRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _refund.Request(jsonRequest);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }

        public ModificationResult Cancel(CancelRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResult = _cancel.Request(jsonRequest);

            return Util.JsonOperation.Deserialize<ModificationResult>(jsonResult);
        }
    }
}