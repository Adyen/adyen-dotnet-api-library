namespace Adyen.EcommLibrary.Service
{
    public class AbstractService
    {
        public Client Client { get; set; }
        protected bool RequiresApiKey { get; private set; } = false;

        protected AbstractService(Client client)
        {
            this.Client = client;
        }
    }
}
