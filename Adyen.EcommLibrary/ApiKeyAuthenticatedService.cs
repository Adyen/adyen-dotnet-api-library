using Adyen.EcommLibrary.Service;

namespace Adyen.EcommLibrary
{
    public class ApiKeyAuthenticatedService : AbstractService
    {
        protected ApiKeyAuthenticatedService(Client client) : base(client)
        {
            IsApiKeyRequired = true;
        }
    }
}
