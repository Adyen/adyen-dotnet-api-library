using Adyen.EcommLibrary.Model;
using Adyen.EcommLibrary.Model.Reccuring;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class RecurringTest:BaseTest
    {
       
        private RecurringDetailsRequest CreateRecurringDetailsRequest()
        {
            var request = new RecurringDetailsRequest
            {
                ShopperReference = "test-123",
                MerchantAccount = "DotNetAlexandros",
               // Recurring = new Recurring(null, ContractEnum.ONECLICK)
            };
            return request;
        }

        private DisableRequest CreateDisableRequest()
        {
            DisableRequest request = new DisableRequest();
            request.ShopperReference = "test-123";
            request.MerchantAccount = "DotNetAlexandros";
                
            return request;
        }
    }
}
