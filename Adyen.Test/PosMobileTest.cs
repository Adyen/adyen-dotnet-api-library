using System;
using System.Net.Http;
using Adyen.Model.PosMobile;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Environment = Adyen.Model.Environment;

namespace Adyen.Test
{
    [TestClass]
    public class PosMobileTest  : BaseTest
    {
    [TestMethod]
        public void TestPosMobileCreateSession()
        {
            var client = CreateMockTestClientApiKeyBasedRequestAsync("mocks/posmobile/create-session.json");
            client.Config.Environment = Environment.Live;
            client.Config.LiveEndpointUrlPrefix = "prefix";
            var service = new PosMobileService(client);
            var response = service.CreateCommunicationSession(new CreateSessionRequest());
            Assert.AreEqual(response.Id, "CS451F2AB1ED897A94");
            ClientInterfaceSubstitute.Received().RequestAsync(
                "https://prefix-checkout-live.adyenpayments.com/checkout/possdk/v68/sessions",
                Arg.Any<String>(), null, new HttpMethod("POST"), default);
        }
    }
}