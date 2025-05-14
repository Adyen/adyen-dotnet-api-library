using Adyen.HttpClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class HttpClientWrapperTest : BaseTest
    {
        [TestMethod]
        public void EmptyRequestBodyPostTest()
        {
            var configWithApiKey = new Config
            {
                Environment = Model.Environment.Test,
                XApiKey = "AQEyhmfxK....LAG84XwzP5pSpVd"
            };
            var mockHttpMessageHandler = new MockHttpMessageHandler("{}", System.Net.HttpStatusCode.OK);
            var httpClient = new System.Net.Http.HttpClient(mockHttpMessageHandler);
            var httpClientWrapper = new HttpClientWrapper(configWithApiKey, httpClient);
            var _ = httpClientWrapper.Request("https://test.com/testpath", null, null, HttpMethod.Post);
            Assert.AreEqual("{}", mockHttpMessageHandler.Input);
        }

      }
}