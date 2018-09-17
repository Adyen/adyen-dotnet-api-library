using Adyen.EcommLibrary.HttpClientHandler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class HeaderRequestTest
    {

        private readonly HttpUrlConnectionClient _httpUrlConnectionClient;
        private string _endpoint = "https://endpoint:8080";

        public HeaderRequestTest()
        {
            _httpUrlConnectionClient = new HttpUrlConnectionClient();
        }
        [TestMethod]
        public void BasicAuthenticationHeadersTest()
        {
            var httpWebRequest = _httpUrlConnectionClient.GetHttpWebRequest(_endpoint, MockPaymentData.CreateConfingMock(), false);

            Assert.IsNotNull(httpWebRequest.UserAgent);
            Assert.AreEqual(httpWebRequest.Address, _endpoint);
            Assert.AreEqual(httpWebRequest.Headers["Accept-Charset"], "UTF-8");
            Assert.AreEqual(httpWebRequest.Headers["Cache-Control"], "no-cache");
            Assert.AreEqual(httpWebRequest.ContentType, "application/json");

            Assert.IsNotNull(httpWebRequest.Headers["Authorization"]);
            Assert.IsTrue(httpWebRequest.UseDefaultCredentials);

            Assert.AreEqual(httpWebRequest.Headers["Cache-Control"], "no-cache");
            Assert.IsNull(httpWebRequest.Headers["x-api-key"]);
        }

        [TestMethod]
        public void ApiKeyBasedHeadersTest()
        {
            var httpWebRequest = _httpUrlConnectionClient.GetHttpWebRequest(_endpoint, MockPaymentData.CreateConfingApiKeyBasedMock(), true);

            Assert.IsNotNull(httpWebRequest.UserAgent);
            Assert.AreEqual(httpWebRequest.Address, _endpoint);
            Assert.AreEqual(httpWebRequest.Headers["Accept-Charset"], "UTF-8");
            Assert.AreEqual(httpWebRequest.Headers["Cache-Control"], "no-cache");
            Assert.AreEqual(httpWebRequest.ContentType, "application/json");

            Assert.IsNull(httpWebRequest.Headers["Authorization"]);
            Assert.IsFalse(httpWebRequest.UseDefaultCredentials);
            
            Assert.IsNotNull(httpWebRequest.Headers["x-api-key"]);
            Assert.AreEqual(httpWebRequest.Headers["x-api-key"], "AQEyhmfxK....LAG84XwzP5pSpVd");
        }
    }
}
