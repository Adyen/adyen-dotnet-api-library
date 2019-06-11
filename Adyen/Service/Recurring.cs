using Adyen.Model.Recurring;
using Adyen.Service.Resource.Recurring;
using System;

namespace Adyen.Service
{
    public class Recurring : AbstractService
    {
        private readonly ListRecurringDetails _listRecurringDetails;
        private Disable _disable;

        public Recurring(Client client) : base(client)
        {
            _listRecurringDetails = new ListRecurringDetails(this);
            _disable = new Disable(this);
        }

        public RecurringDetailsResult ListRecurringDetails(RecurringDetailsRequest request)
        {
            RecurringDetailsResult result = null;
            try
            {
                var jsonRequest = Util.JsonOperation.SerializeRequest(request);
                var jsonResponse = _listRecurringDetails.Request(jsonRequest);
                result = Util.JsonOperation.Deserialize<RecurringDetailsResult>(jsonResponse);
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
                result = Util.JsonOperation.Deserialize<DisableResult>(jsonResponse);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        } 
    }
}
