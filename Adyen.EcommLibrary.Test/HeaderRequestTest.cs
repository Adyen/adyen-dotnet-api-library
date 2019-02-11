using Adyen.EcommLibrary.HttpClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.EcommLibrary.Test
{
    [TestClass]
    public class HeaderRequestTest
    {

        private readonly HttpUrlConnectionClient _httpUrlConnectionClient;
        private readonly string _endpoint = "https://endpoint:8080";

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

        [TestMethod]
        public void IdempotencyKeyNotPresentInHeaderIfExcluded()
        {
            var httpWebRequest = _httpUrlConnectionClient.GetHttpWebRequest(_endpoint, MockPaymentData.CreateConfingApiKeyBasedMock(), true);

            Assert.IsNull(httpWebRequest.Headers["Idempotency-Key"]);
        }

        [TestMethod]
        public void IdempotencyKeyNotPresentInHeaderIfNull()
        {
            var httpWebRequest = _httpUrlConnectionClient.GetHttpWebRequest(_endpoint, MockPaymentData.CreateConfingApiKeyBasedMock(), true, null);

            Assert.IsNull(httpWebRequest.Headers["Idempotency-Key"]);
        }

        [TestMethod]
        public void IdempotencyKeyNotPresentInHeaderIfEmptryString()
        {
            var httpWebRequest = _httpUrlConnectionClient.GetHttpWebRequest(_endpoint, MockPaymentData.CreateConfingApiKeyBasedMock(), true, string.Empty);

            Assert.IsNull(httpWebRequest.Headers["Idempotency-Key"]);
        }

        [TestMethod]
        public void IdempotencyKeyPresentInHeaderIfSpecified()
        {
            var expectedKey = "idempotencyKey";
            var httpWebRequest = _httpUrlConnectionClient.GetHttpWebRequest(_endpoint, MockPaymentData.CreateConfingApiKeyBasedMock(), true, expectedKey);

            Assert.IsNotNull(httpWebRequest.Headers["Idempotency-Key"]);
            Assert.AreEqual(expectedKey, httpWebRequest.Headers["Idempotency-Key"]);
        }
    }
}
