using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Model.Payout;
using Adyen.Service.Resource.Payout;
using Newtonsoft.Json;

namespace Adyen.Service
{
    public class Payout : AbstractService
    {
        private readonly StoreDetailAndSubmitThirdParty _storeDetailAndSubmitThirdParty;
        private readonly ConfirmThirdParty _confirmThirdParty;
        private readonly DeclineThirdParty _declineThirdParty;
        private readonly StoreDetail _storeDetail;
        private readonly SubmitThirdParty _submitThirdParty;
        private readonly PayoutService _payoutService;

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

        /// <summary>
        /// Post storeDetailAndSubmitThirdPartyAsync API call 
        /// </summary>
        /// <param name="storeDetailAndSubmitRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public async Task<StoreDetailAndSubmitResponse> StoreDetailAndSubmitThirdPartyAsync(
            StoreDetailAndSubmitRequest storeDetailAndSubmitRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = storeDetailAndSubmitRequest.ToJson();
            var jsonResponse = await _storeDetailAndSubmitThirdParty.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<StoreDetailAndSubmitResponse>(jsonResponse);
        }
        
        /// <summary>
        /// Post storeDetailAndSubmitThirdParty API call 
        /// </summary>
        /// <param name="storeDetailAndSubmitRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public StoreDetailAndSubmitResponse StoreDetailAndSubmitThirdParty(StoreDetailAndSubmitRequest storeDetailAndSubmitRequest, RequestOptions requestOptions = null)
        {
            return StoreDetailAndSubmitThirdPartyAsync(storeDetailAndSubmitRequest, requestOptions).GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Post ConfirmThirdPartyAsync API call 
        /// </summary>
        /// <param name="modifyRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public async Task<ModifyResponse> ConfirmThirdPartyAsync(ModifyRequest modifyRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = modifyRequest.ToJson();
            var jsonResponse = await _confirmThirdParty.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModifyResponse>(jsonResponse);
        }

        /// <summary>
        /// Post ConfirmThirdParty API call 
        /// </summary>
        /// <param name="modifyRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public ModifyResponse ConfirmThirdParty(ModifyRequest modifyRequest, RequestOptions requestOptions = null)
        {
            return ConfirmThirdPartyAsync(modifyRequest, requestOptions).GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Post DeclineThirdPartyAsync API call 
        /// </summary>
        /// <param name="modifyRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public async Task<ModifyResponse> DeclineThirdPartyAsync(ModifyRequest modifyRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = modifyRequest.ToJson();
            var jsonResponse = await _declineThirdParty.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<ModifyResponse>(jsonResponse);
        }

        /// <summary>
        /// Post DeclineThirdParty API call 
        /// </summary>
        /// <param name="modifyRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public ModifyResponse DeclineThirdParty(ModifyRequest modifyRequest, RequestOptions requestOptions = null)
        {
            return DeclineThirdPartyAsync(modifyRequest, requestOptions).GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Post StoreDetailAsync API call 
        /// </summary>
        /// <param name="storeDetailRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public async Task<StoreDetailResponse> StoreDetailAsync(StoreDetailRequest storeDetailRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = storeDetailRequest.ToJson();
            var jsonResponse = await _storeDetail.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<StoreDetailResponse>(jsonResponse);
        }
        
        /// <summary>
        /// Post StoreDetail API call 
        /// </summary>
        /// <param name="storeDetailRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public StoreDetailResponse StoreDetail(StoreDetailRequest storeDetailRequest, RequestOptions requestOptions = null)
        {
            return StoreDetailAsync(storeDetailRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Post SubmitThirdPartyAsync API call 
        /// </summary>
        /// <param name="submitRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public async Task<SubmitResponse> SubmitThirdPartyAsync(SubmitRequest submitRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = submitRequest.ToJson();
            var jsonResponse = await _submitThirdParty.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<SubmitResponse>(jsonResponse);
        }

        /// <summary>
        /// Post SubmitThirdParty API call 
        /// </summary>
        /// <param name="submitRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public SubmitResponse SubmitThirdParty(SubmitRequest submitRequest, RequestOptions requestOptions = null)
        {
            return SubmitThirdPartyAsync(submitRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Post PayoutSubmitAsync API call 
        /// </summary>
        /// <param name="payoutRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public async Task<PayoutResponse> PayoutSubmitAsync(PayoutRequest payoutRequest, RequestOptions requestOptions = null)
        {
            var jsonRequest = payoutRequest.ToJson();
            var jsonResponse = await _payoutService.RequestAsync(jsonRequest, requestOptions);
            return JsonConvert.DeserializeObject<PayoutResponse>(jsonResponse);
        }

        /// <summary>
        /// Post PayoutSubmit API call 
        /// </summary>
        /// <param name="payoutRequest"></param>
        /// <param name="requestOptions"></param>
        /// <returns>PaymentsResponse</returns>
        public PayoutResponse PayoutSubmit(PayoutRequest payoutRequest, RequestOptions requestOptions = null)
        {
            return PayoutSubmitAsync(payoutRequest, requestOptions).GetAwaiter().GetResult();
        }
    }
}
