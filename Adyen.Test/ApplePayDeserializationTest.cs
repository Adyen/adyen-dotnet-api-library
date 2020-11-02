using Adyen.Model.Checkout;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Adyen.Test
{
    [TestClass]
    public class ApplePayDeserializationTest : BaseTest
    {
        [TestMethod]
        public void Can_deserialize_applepay_paymentmethod_request()
        {
            var mockPath = GetMockFilePath("Mocks/checkout/paymentmethod-applepay-request.json");
            var response = MockFileToString(mockPath);

            var paymentMethod = JsonConvert.DeserializeObject<DefaultPaymentMethodDetails>(response);

            Assert.IsNotNull(paymentMethod);
            Assert.AreEqual("applepay", paymentMethod.Type);
            Assert.AreEqual("VNRWtuNlNEWkRCSm1xWndjMDFFbktkQU...", paymentMethod.ApplePayToken);
        }
    }
}