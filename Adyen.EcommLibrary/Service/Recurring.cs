using Adyen.EcommLibrary.Service.Resource.Reccuring;

namespace Adyen.EcommLibrary.Service
{
    public class Recurring:AbstractService
    {
        private ListReccuringDetails _listRecurringDetails;
        private Disable _disable;

        public Recurring(Client client) : base(client)
        {
            _listRecurringDetails=new ListReccuringDetails(this);

        }
    }
}
