using Adyen.EcommLibrary.Model.Reccuring;
using Adyen.EcommLibrary.Service.Resource.Reccuring;
using System;

namespace Adyen.EcommLibrary.Service
{
    public class Recurring : AbstractService
    {
        private readonly ListReccuringDetails _listRecurringDetails;
        private Disable _disable;

        public Recurring(Client client) : base(client)
        {
            _listRecurringDetails = new ListReccuringDetails(this);
            _disable = new Disable(this);
        }

        public RecurringDetailsResult ListRecurringDetails(RecurringDetailsRequest request)
        {
            RecurringDetailsResult result = null;
            try
            {
                var jsonRequest = Util.JsonOperation.SerializeRequest(request);
                var jsonResponse = _listRecurringDetails.Request(jsonRequest);
                result = Util.JsonOperation.Deserealize<RecurringDetailsResult>(jsonResponse);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;

        }

        public DisableResult Disable(DisableRequest disableRequest)
        {
            DisableResult result = null;
            try
            {
                var jsonRequest = Util.JsonOperation.SerializeRequest(disableRequest);
                var jsonResponse = _disable.Request(jsonRequest);
                result = Util.JsonOperation.Deserealize<DisableResult>(jsonResponse);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        } 
    }
}
