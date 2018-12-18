using Adyen.EcommLibrary.Model.CheckoutUtility;
using Adyen.EcommLibrary.Service.Resource.CheckoutUtility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.EcommLibrary.Service
{
    public class CheckoutUtility : AbstractService
    {
        private OriginKeys _originKeys;
        public CheckoutUtility(Client client)
            : base(client)
        {
            IsApiKeyRequired = true;
            _originKeys = new OriginKeys(this);
        }

        public OriginKeysResponse OriginKeys(OriginKeysRequest originKeysRequest)
        {
            var jsonRequest = Util.JsonOperation.SerializeRequest(originKeysRequest);
            var jsonResponse = _originKeys.Request(jsonRequest);
            return JsonConvert.DeserializeObject<OriginKeysResponse>(jsonResponse);
        }
    }
}
