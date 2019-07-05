using Adyen.Model.BinLookup;
using Adyen.Service.Resource.BinLookup;
using Newtonsoft.Json;

namespace Adyen.Service
{
    public class BinLookup : AbstractService
    {
        private readonly Get3dsAvailability get3dsAvailability;
        private readonly GetCostEstimate getCostEstimate;

        public BinLookup(Client client)
            : base(client)
        {
            this.get3dsAvailability = new Get3dsAvailability(this);
            this.getCostEstimate = new GetCostEstimate(this);
        }

        public ThreeDSAvailabilityResponse ThreeDsAvailability(ThreeDSAvailabilityRequest threeDsAvailabilityRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(threeDsAvailabilityRequest);
            var jsonResponse = get3dsAvailability.Request(jsonRequest);
            return JsonConvert.DeserializeObject<ThreeDSAvailabilityResponse>(jsonResponse);
        }

        public CostEstimateResponse CostEstimate(CostEstimateRequest costEstimateRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(costEstimateRequest);
            var jsonResponse = getCostEstimate.Request(jsonRequest);
            return JsonConvert.DeserializeObject<CostEstimateResponse>(jsonResponse);
        }
    }
}
