using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Adyen.HttpClient;
using Adyen.Model.Management;
using Adyen.Model.TerminalApi;
using Adyen.Service.Management;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Adyen.Test
{
    [TestClass]
    public class HttpClientWrapperTest : BaseTest
    {
        [TestMethod]
        public void EmptyRequestBodyPostTest()
        {
            var mockHttpMessageHandler = new MockHttpMessageHandler("{}", System.Net.HttpStatusCode.OK);
            var httpClient = new System.Net.Http.HttpClient(mockHttpMessageHandler);
            var httpClientWrapper = new HttpClientWrapper(MockPaymentData.CreateConfigApiKeyBasedMock(), httpClient);
            var _ = httpClientWrapper.Request("https://test.com/testpath", null, null, HttpMethod.Post);
            Assert.AreEqual("{}", mockHttpMessageHandler.Input);
        }

      }
}