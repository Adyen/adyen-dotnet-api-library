using Adyen.EcommLibrary.Service;

namespace Adyen.EcommLibrary
{
    public class ApiKeyAuthenticatedService : AbstractService
    {
<<<<<<< HEAD
        protected new bool RequiresApiKey { get;  set; } = true;
=======
        protected new bool RequiresApiKey { get; private set; } = true;
>>>>>>> c8d8d7aa0e209a3eb009ca5104afd52e2233b372

        protected ApiKeyAuthenticatedService(Client client) : base(client)
        {

        }
    }
}
