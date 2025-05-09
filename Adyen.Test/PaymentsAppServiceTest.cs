using System.Net.Http;
using Adyen.Model;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Environment = Adyen.Model.Environment;

namespace Adyen.Test
{
    [TestClass]
    public class PaymentsAppServiceTest : BaseTest
    {
        [TestMethod]
        public void PaymentsAppServiceTESTUrlTest()
        {
            var client = CreateMockForAdyenClientTest(new Config());
            client.SetEnvironment(Environment.Test, "companyUrl");
            var checkout = new PaymentsAppService(client);
            checkout.RevokePaymentsAppAsync("{merchantId}", "{installationId}").GetAwaiter();

            ClientInterfaceSubstitute.Received().RequestAsync("https://management-test.adyen.com/v1/merchants/{merchantId}/paymentsApps/{installationId}/revoke",
                Arg.Any<string>(), null, new HttpMethod("POST"), default);
        }
        
        [TestMethod]
        public void PaymentsAppServiceLIVEUrlTest()
        {
            var client = CreateMockForAdyenClientTest(new Config());
            client.SetEnvironment(Environment.Live, "companyUrl");
            var checkout = new PaymentsAppService(client);
            checkout.RevokePaymentsAppAsync("{merchantId}", "{installationId}").GetAwaiter();

            ClientInterfaceSubstitute.Received().RequestAsync("https://management-live.adyen.com/v1/merchants/{merchantId}/paymentsApps/{installationId}/revoke",
                Arg.Any<string>(), null, new HttpMethod("POST"), default);
        }
    }
}