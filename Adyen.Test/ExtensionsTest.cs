using System.Collections.Generic;
using System.Net.Http;
using Adyen.Model.BalanceControl;
using Adyen.Model.Checkout;
using Adyen.Service;
using Adyen.Service.BalancePlatform;
using Adyen.Service.Checkout;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Environment = Adyen.Model.Environment;

namespace Adyen.Test
{
    [TestClass]
    public class ExtensionsTest : BaseTest
    {
        private Client _client;

        [TestInitialize]
        public void Init()
        {
            _client = CreateMockTestClientApiKeyBasedRequestAsync("");
            _client.Config.Environment = Environment.Live;
            _client.Config.LiveEndpointUrlPrefix = "prefix";
        }

        [TestMethod]
        public void TestDeviceRenderOptionsObjectListToString()
        {
            var deviceRenderOptions = new DeviceRenderOptions
            {
                SdkInterface = DeviceRenderOptions.SdkInterfaceEnum.Native,
                SdkUiType = new List<DeviceRenderOptions.SdkUiTypeEnum>
                    { DeviceRenderOptions.SdkUiTypeEnum.MultiSelect, DeviceRenderOptions.SdkUiTypeEnum.OtherHtml }
            };
            var expected = "\"multiSelect\"";
            Assert.IsTrue(deviceRenderOptions.ToJson().Contains(expected));
        }

        [TestMethod]
        public void TestToCollectionsStringEmpty()
        {
            var paymentVerificationResponse = new PaymentVerificationResponse(merchantReference: "ref",
                shopperLocale: "NL",
                additionalData: new Dictionary<string, string> { { "scaExemptionRequested", "lowValue" } });
            var expected = "\"scaExemptionRequested\": \"lowValue\"";
            Assert.IsTrue(paymentVerificationResponse.ToJson().Contains(expected));
        }

        [TestMethod]
        public void TestPalLiveEndPoint()
        {
            var service = new BalanceControlService(_client);
            service.BalanceTransfer(new BalanceTransferRequest());
            ClientInterfaceSubstitute.Received().RequestAsync(
                "https://prefix-pal-live.adyenpayments.com/pal/servlet/BalanceControl/v1/balanceTransfer",
                "{}", null, HttpMethod.Post, default);
        }

        [TestMethod]
        public void TestCheckoutLiveEndPoint()
        {
            var service = new PaymentsService(_client);
            service.Donations(new DonationPaymentRequest());
            ClientInterfaceSubstitute.Received().RequestAsync(
                "https://prefix-checkout-live.adyenpayments.com/checkout/v70/donations",
                Arg.Any<string>(), null, HttpMethod.Post, default);
        }

        [TestMethod]
        public void TestBclLiveEndPoint()
        {
            var service = new AccountHoldersService(_client);
            service.GetAllBalanceAccountsOfAccountHolder("id", offset: 3, limit: 5);
            ClientInterfaceSubstitute.Received().RequestAsync(
                "https://balanceplatform-api-live.adyen.com/bcl/v2/accountHolders/id/balanceAccounts?offset=3&limit=5",
                null, null, HttpMethod.Get, default);
        }
    }
}
