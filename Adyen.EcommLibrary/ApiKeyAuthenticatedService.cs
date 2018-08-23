using Adyen.EcommLibrary.Service;

namespace Adyen.EcommLibrary
{
    public class ApiKeyAuthenticatedService : AbstractService
    {
        protected new bool RequiresApiKey { get;  set; } = true;

        protected ApiKeyAuthenticatedService(Client client) : base(client)
        {

        }
    }
}
