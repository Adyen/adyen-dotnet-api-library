namespace Adyen.EcommLibrary.Service
{
    public class AbstractService
    {
        public Client Client { get; set; }

        public bool IsApiKeyRequired { get; set; } = false;
        
        protected AbstractService(Client client)
        {
            this.Client = client;
        }
    }
}
