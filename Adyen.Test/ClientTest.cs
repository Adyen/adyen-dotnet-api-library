using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void HttpClientFirstCallReturnsDefaultHttpClient()
        {
            var client = new Client(new Config()); 
            var httpClient = client.HttpClient;
            Assert.IsNotNull(httpClient);
        }
    }
}