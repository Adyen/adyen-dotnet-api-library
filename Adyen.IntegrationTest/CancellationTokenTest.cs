using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.HttpClient;
using Adyen.HttpClient.Interfaces;
using Adyen.Model;
using Adyen.Service.Checkout;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.IntegrationTest
{
    [TestClass]
    public class CancellationTokenTest : BaseTest
    {
        
        [TestMethod]
        public void CancellationTokenDelayTest()
        {
            var client = new AdyenClient(new Config())
            {
                HttpClient = new MyDelayedClient(new Config(), new System.Net.Http.HttpClient())
            };
            var cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.CancelAfter(1000);

            try
            {
                var service = new PaymentLinksService(client);
                var response = service.GetPaymentLinkAsync("linkId", null, cancellationTokenSource.Token).Result;
            }
            catch (System.AggregateException e)
            {
                Assert.AreEqual(e.Message, "One or more errors occurred. (A task was canceled.)");
            }
        }
    }

    public class MyDelayedClient : IClient
    {
        private readonly System.Net.Http.HttpClient _httpClient;
        
        public MyDelayedClient(Config config, System.Net.Http.HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public string Request(string endpoint, string json, RequestOptions requestOptions = null,
            HttpMethod httpMethod = null)
        {
            throw new NotImplementedException();
        }

        public async Task<string> RequestAsync(string endpoint, string json, RequestOptions requestOptions = null,
            HttpMethod httpMethod = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            using var response = await _httpClient.SendAsync(
                new HttpRequestMessage(httpMethod, "https://httpstat.us/504?sleep=60000"), cancellationToken);
            var responseText = await response.Content.ReadAsStringAsync(cancellationToken);
            return responseText;
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}