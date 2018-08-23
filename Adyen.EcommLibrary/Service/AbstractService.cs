namespace Adyen.EcommLibrary.Service
{
    public class AbstractService
    {
        public Client Client { get; set; }
       
        protected AbstractService(Client client)
        {
            this.Client = client;
        }
    }
}
