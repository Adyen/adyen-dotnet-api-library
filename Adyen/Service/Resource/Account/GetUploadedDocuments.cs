using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class GetUploadedDocuments : Resource
    {
        public GetUploadedDocuments(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/getUploadedDocuments")
        {
        }
    }
}
