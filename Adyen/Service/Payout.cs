using Adyen.Model.Payout;
using Adyen.Service.Resource.Payout;
using Newtonsoft.Json;

namespace Adyen.Service
{
    public class Payout : AbstractService
    {
        private StoreDetailAndSubmitThirdParty _storeDetailAndSubmitThirdParty;
        private ConfirmThirdParty _confirmThirdParty;
        private DeclineThirdParty _declineThirdParty;
        private StoreDetail _storeDetail;
        private SubmitThirdParty _submitThirdParty;
        private PayoutService _payoutService;

        public Payout(Client client)
            : base(client)
        {
            _storeDetailAndSubmitThirdParty = new StoreDetailAndSubmitThirdParty(this);
            _confirmThirdParty = new ConfirmThirdParty(this);
            _declineThirdParty = new DeclineThirdParty(this);
            _storeDetail = new StoreDetail(this);
            _submitThirdParty = new SubmitThirdParty(this);
            _payoutService = new PayoutService(this);
        }

        public StoreDetailAndSubmitResponse StoreDetailAndSubmitThirdParty(StoreDetailAndSubmitRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResponse = _storeDetailAndSubmitThirdParty.Request(jsonRequest);
            return JsonConvert.DeserializeObject<StoreDetailAndSubmitResponse>(jsonResponse);
        }

        public ConfirmThirdPartyResponse ConfirmThirdParty(ConfirmThirdPartyRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResponse = _confirmThirdParty.Request(jsonRequest);
            return JsonConvert.DeserializeObject<ConfirmThirdPartyResponse>(jsonResponse);
        }
        
        public DeclineThirdPartyResponse DeclineThirdParty(DeclineThirdPartyRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResponse = _declineThirdParty.Request(jsonRequest);
            return JsonConvert.DeserializeObject<DeclineThirdPartyResponse>(jsonResponse);
        }

        public StoreDetailResponse StoreDetail(StoreDetailRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResponse = _storeDetail.Request(jsonRequest);
            return JsonConvert.DeserializeObject<StoreDetailResponse>(jsonResponse);
        }

        public SubmitResponse SubmitThirdParty(SubmitRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResponse = _submitThirdParty.Request(jsonRequest);
            return JsonConvert.DeserializeObject<SubmitResponse>(jsonResponse);
        }

        public PayoutResponse payout(PayoutRequest request)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(request);
            var jsonResponse = _payoutService.Request(jsonRequest);
            return JsonConvert.DeserializeObject<PayoutResponse>(jsonResponse);
        }
    }
}
