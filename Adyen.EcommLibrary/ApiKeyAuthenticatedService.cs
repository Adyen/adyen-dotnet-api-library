using Adyen.EcommLibrary.Service;

namespace Adyen.EcommLibrary
{
    public class ApiKeyAuthenticatedService : AbstractService
    {
        public new bool RequiresApiKey { get;  set; } = true;

        protected ApiKeyAuthenticatedService(Client client) : base(client)
        {

        }
    }
}
