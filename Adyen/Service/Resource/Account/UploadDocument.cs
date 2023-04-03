using Adyen.Constants;

namespace Adyen.Service.Resource.Account
{
    public class UploadDocument : Resource
    {
        public UploadDocument(AbstractService abstractService)
            : base(abstractService, abstractService.Client.Config.MarketPayEndpoint + "/Account/" + ClientConfig.MarketPayAccountApiVersion + "/uploadDocument")
        {
        }
    }
}
